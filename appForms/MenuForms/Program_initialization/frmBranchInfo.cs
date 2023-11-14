using FlexMax_db.Commander;
using FlexMax_db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appFelxMax.appClass.clsDesign;
using appFelxMax.appForms.OtherForms;

namespace appFelxMax.appForms.MenuForms
{
    public partial class frmBranch_Info : Form
    {

        #region Variable
        clsCommander<TBL_Branch> cmdBranch = new clsCommander<TBL_Branch>();
        TBL_Branch vTblBranch = new TBL_Branch();

        clsCommander<TBL_Company> cmdCompany = new clsCommander<TBL_Company>();
        TBL_Company vTblCompany = new TBL_Company();
        #endregion

        #region Constructor

        public frmBranch_Info()
        {
            InitializeComponent();

        }
        #endregion

        #region FormLoad
        private void frmBranch_Info_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgvBranches);
            fnClear_Data();

        }
        #endregion

        #region Functions
        public void fnFill_GV()
        {
            try
            {

                dgvBranches.DataSource = (from vBranch in cmdBranch.GetAll().Where(state=>state.Branch_State == true)
                                        select new
                                        {
                                            Branch_ID = vBranch.Branch_ID,
                                            Branch_Name = vBranch.Branch_Name,
                                            Branch_Address = vBranch.Branch_Address,
                                            Branch_Mobile = vBranch.Branch_Mobile,
                                            Branch_Mobile2 = vBranch.Branch_Mobile2,
                                            Branch_Open_Date = vBranch.Branch_Open_Date,
                                            Branch_State = vBranch.Branch_State==true ? "نشط" : "غير نشط",
                                            Branch_Note = vBranch.Branch_Note,
                                            Com_Name = vBranch.TBL_Company.Com_Name
                                        }).ToList();
                dgvBranches.Columns["Branch_ID"].HeaderText = "رقم";
                dgvBranches.Columns["Branch_Name"].HeaderText = "اسم";
                dgvBranches.Columns["Branch_Address"].HeaderText = "العنوان";
                dgvBranches.Columns["Branch_Mobile"].HeaderText = "الهاتف";
                dgvBranches.Columns["Branch_Mobile2"].HeaderText = "الهاتف2";
                dgvBranches.Columns["Branch_Open_Date"].HeaderText = "تاريخ الافتتاح";
                dgvBranches.Columns["Branch_State"].HeaderText = "حالة الفرع";
                dgvBranches.Columns["Branch_Note"].HeaderText = "ملاحظات";
                dgvBranches.Columns["Com_Name"].HeaderText = "المؤسسة التابع لها";

            }
            catch(Exception ex)
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في تحميل البيانات", frmNotifications.enmType.vError);
                MessageBox.Show(ex.Message);
            }
        }

        public int fnMax_ID()
        {
            var x = cmdBranch.GetAll().ToList();
            if(x.Count != 0)
            {
                var vLastRow = cmdBranch.GetAll().Where(id => id.Branch_ID == cmdBranch.GetAll().Max(mID => mID.Branch_ID)).FirstOrDefault();
                var vLastID = vLastRow.Branch_ID;
                return vLastID + 1;
            }
            else return 1;
        }

        //public void fnGet_Company()
        //{
        //    var data = (from vCom in cmdCompany.GetAll()
        //                select new
        //                { 
        //                    ID = vCom.Com_ID,
        //                    Name = vCom.Com_Name
        //                }).ToList();
        //    cmbCompany.DataSource = data;
        //    cmbCompany.DisplayMember = "Name";
        //    cmbCompany.ValueMember = "ID";
        //}
        public void fnClear_Data()
        {
            vTblBranch = new TBL_Branch();
            vTblCompany = new TBL_Company();

            txtBranch_ID.Text = fnMax_ID().ToString();
            txtBranch_Name.Text = "";
            chkBranch_State.Checked = false;

            fnFill_GV();
        }

        public bool fnValidation()
        {
            if (txtBranch_ID.Text == "") return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtBranch_ID.Text, "[^0-9]")) return false;
            else if (txtBranch_Name.Text == "") return false;
            else return true;
        }

        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblBranch = cmdBranch.GetAll().Where(id => id.Branch_ID == Convert.ToInt32(txtBranch_ID.Text)).FirstOrDefault();
                    if (vTblBranch != null)
                    {
                        vTblBranch.Branch_Name = txtBranch_Name.Text;
                        vTblBranch.Branch_Open_Date = dtpBranch_S_Date.Value;
                        vTblBranch.Branch_State = chkBranch_State.Checked;
                        vTblBranch.Com_ID = vTblCompany.Com_ID;
                        cmdBranch.Update_Data(vTblBranch);
                    }
                    else
                    {
                        vTblBranch = new TBL_Branch
                        {
                            Branch_ID = Convert.ToInt32(txtBranch_ID.Text),
                            Branch_Name = txtBranch_Name.Text,
                            Branch_Open_Date = dtpBranch_S_Date.Value,
                            Branch_State = chkBranch_State.Checked,
                            Com_ID = vTblCompany.Com_ID
                    };
                        cmdBranch.Insert_Data(vTblBranch);
                    }

                    fnClear_Data();
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("تم حفظ البيانات", frmNotifications.enmType.vSuccess);
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("تأكد من إدخال البيانات كاملة", frmNotifications.enmType.vWarning);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Branch_Name_Index"))
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("لم يتم حفظ البيانات \n اسم الفرع مسجل مسبقا", frmNotifications.enmType.vError);
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("خطأ في حفظ البيانات", frmNotifications.enmType.vError);
                }
            }
        }

        public void fnDelete()
        {
            try
            {
                if (vTblBranch != null)
                {
                    var vResult = MessageBox.Show("هل تريد حذف الفرع", "تأكيد!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vResult == DialogResult.Yes)
                    {
                        vTblBranch.Branch_State = false;
                        cmdBranch.Update_Data(vTblBranch);
                        fnClear_Data();

                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم حذف الفرع بنجاح", frmNotifications.enmType.vSuccess);
                    }
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("برجاء اختيار الفرع المراد حذفه", frmNotifications.enmType.vWarning);
                }
                
            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في حذف البيانات", frmNotifications.enmType.vError);
            }
        }
        #endregion

        #region Events

        #endregion



        private void chkBranch_State_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBranch_State.Checked == true)
            {
                chkBranch_State.ForeColor = Color.Green;
                chkBranch_State.Text = "نشط";
            }
            else
            {
                chkBranch_State.ForeColor = Color.Red;
                chkBranch_State.Text = "غير نشط";
            }
        }


        //private void dgvBranches_Click(object sender, EventArgs e)
        //{
        //    if (dgvBranches.RowCount > 0)
        //    {
        //        try
        //        {
        //            int vID = Convert.ToInt32(dgvBranches.CurrentRow.Cells[0].Value);

        //            vTblBranch = cmdBranch.GetAll().Where(id => id.Branch_ID == vID).FirstOrDefault();

        //            txtBranch_ID.Text = vTblBranch.Branch_ID.ToString();
        //            txtBranch_Name.Text = vTblBranch.Branch_Name;
        //            dtpBranch_S_Date.Value = (DateTime)vTblBranch.Branch_Open_Date;
        //            chkBranch_State.Checked = (bool)vTblBranch.Branch_State;
        //        }
        //        catch
        //        {
        //            frmNotifications nfrm = new frmNotifications();
        //            nfrm.fnShowAlert("خطأ في اختيار البيانات", frmNotifications.enmType.vError);
        //        }
        //    }
        //}

        private void frmBranch_Info_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.F1) fnClear_Data(); 
                else if (e.KeyData == Keys.F2) fnSave(); 
                else if (e.KeyData == Keys.Delete) fnDelete(); 
            }
            catch
            {

            }
        }

        private void txtBranch_ID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBranch_ID.Text, "[^0-9]"))
            {
                MessageBox.Show("برجاء ادخال ارقام فقط");
                txtBranch_ID.Text = "";
            }
        }

    }
}
