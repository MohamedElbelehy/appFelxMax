using appFelxMax.appClass.clsDesign;
using appFelxMax.appForms.OtherForms;
using FlexMax_db;
using FlexMax_db.Commander;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFelxMax.appForms.MenuForms.AccountForms
{
    public partial class frmTreasure_MainCash : Form
    {
        #region Variable
        clsCommander<TBL_MainCash> cmdMainCash = new clsCommander<TBL_MainCash>();
        TBL_MainCash vTblMainCash = new TBL_MainCash();

        clsCommander<TBL_Branch> cmdBranch = new clsCommander<TBL_Branch>();
        TBL_Branch vTblBranch = new TBL_Branch();
        #endregion


        #region Constructor
        public frmTreasure_MainCash()
        {
            InitializeComponent();
        }
        #endregion


        #region FormLoad
        private void frmTreasure_MainCash_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgv);
            fnClear_Data();
        }
        #endregion


        #region Functions
        public int fnMax_ID()
        {
            var x = cmdMainCash.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLastRow = cmdMainCash.GetAll().FirstOrDefault(id => id.MainCash_ID == cmdMainCash.GetAll().Max(mID => mID.MainCash_ID));
                var vLastID = vLastRow.MainCash_ID;
                return vLastID + 1;
            }
            else return 1;
        }

        public void fnClear_Data()
        {

            vTblBranch = new TBL_Branch();
            vTblMainCash = new TBL_MainCash();
            fnGet_Branch();
            
            txt_Balance.Value = 0;
            txt_ID.Text = fnMax_ID().ToString();
            txt_Notes.Text = "";
            txt_S_Balance.Value = 0;
            txt_Z_Balance.Value = 0;
            chk_State.Checked = true;
            cmbBranch.SelectedIndex = 0;
            fnFill_GV();

        }
        public void fnGet_Branch()
        {
            cmbBranch.DataSource = (from vBranch in cmdBranch.GetAll()
                                    select new 
                                    {
                                        ID = vBranch.Branch_ID,
                                        Name = vBranch.Branch_Name
                                    }).ToList();
            cmbBranch.DisplayMember = "Name";
            cmbBranch.ValueMember = "ID";
        }

        public void fnFill_GV()
        {
            dgv.DataSource = (from vCash in cmdMainCash.GetBy(id => id.MainCash_State == true)
                              select new
                              {
                                    ID = vCash.Branch_ID,
                                    Name = vCash.MainCash_Name,
                                    Date = vCash.MainCash_S_Date,
                                    Balance = vCash.MainCash_Balance,
                                    Branch_Name = vCash.TBL_Branch.Branch_Name,
                              }).ToList();
            dgv.Columns["ID"].HeaderText = "رقم الخزنة";
            dgv.Columns["ID"].DisplayIndex = 0;

            dgv.Columns["Name"].HeaderText = "اسم الخزنة";
            dgv.Columns["Name"].DisplayIndex = 1;

            dgv.Columns["Date"].HeaderText = "تاريخ الافتتاح";
            dgv.Columns["Date"].DisplayIndex = 2;

            dgv.Columns["Balance"].HeaderText = "الرصيد";
            dgv.Columns["Balance"].DisplayIndex = 3;

            dgv.Columns["Branch_Name"].HeaderText = "اسم الفرع";
            dgv.Columns["Branch_Name"].DisplayIndex = 4;

        }


        public bool fnValidaion()
        {
            if (txt_ID.Text == "") return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_ID.Text, "[^0-9]")) return false;
            else if (cmbBranch.SelectedIndex == -1) return false;
            else return true;
        }


        public void fnSave()
        {
            try
            {
                if (fnValidaion())
                {
                    vTblMainCash = cmdMainCash.GetAll().FirstOrDefault(id => id.MainCash_ID == Convert.ToInt32(txt_ID.Text));
                    if (vTblMainCash != null)
                    {
                        vTblBranch = cmdBranch.GetAll().FirstOrDefault(id => id.Branch_Name == cmbBranch.Text);

                        vTblMainCash.MainCash_Name = txt_Name.Text;
                        vTblMainCash.MainCash_Balance = (float?)txt_Balance.Value;
                        vTblMainCash.MainCash_S_Balance = (float?)txt_S_Balance.Value;
                        vTblMainCash.MainCash_Z_Balance = (float?)txt_Z_Balance.Value;
                        vTblMainCash.MainCash_State = chk_State.Checked;
                        vTblMainCash.MainCash_Note = txt_Notes.Text;
                        vTblMainCash.Branch_ID = vTblBranch.Branch_ID;
                        cmdMainCash.Update_Data(vTblMainCash);
                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم تعديل البيانات", frmNotifications.enmType.vSuccess);
                    }
                    else
                    {
                        vTblMainCash = new TBL_MainCash();
                        vTblBranch = cmdBranch.GetAll().FirstOrDefault(id => id.Branch_Name == cmbBranch.Text);

                        vTblMainCash.MainCash_ID = fnMax_ID();
                        vTblMainCash.MainCash_Name = txt_Name.Text;
                        vTblMainCash.MainCash_S_Date = dtp_S_Date.Value;
                        vTblMainCash.MainCash_Balance = (float?)txt_Balance.Value;
                        vTblMainCash.MainCash_S_Balance = (float?)txt_S_Balance.Value;
                        vTblMainCash.MainCash_Z_Balance = (float?)txt_Z_Balance.Value;
                        vTblMainCash.MainCash_State = chk_State.Checked;
                        vTblMainCash.MainCash_Note = txt_Notes.Text;
                        vTblMainCash.Branch_ID = vTblBranch.Branch_ID;
                        cmdMainCash.Insert_Data(vTblMainCash);
                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم حفظ البيانات", frmNotifications.enmType.vSuccess);
                    }
                }else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("تأكد من إدخال البيانات كاملة", frmNotifications.enmType.vWarning);
                }
            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في حفظ البيانات", frmNotifications.enmType.vError);
            }

        }

        public void fnDelet()
        {
            try
            {
                if(vTblMainCash != null)
                {
                    var vResult = MessageBox.Show("هل تريد حذف الفرع", "تأكيد!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vResult == DialogResult.Yes)
                    {
                        vTblMainCash.MainCash_State = false;
                        cmdMainCash.Update_Data(vTblMainCash);
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

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_ID.Text, "[^0-9]"))
            {
                MessageBox.Show("برجاء ادخال ارقام فقط");
                txt_ID.Text = "";
            }
        }

        private void chk_State_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_State.Checked == true)
            {
                chk_State.ForeColor = Color.Green;
                chk_State.Text = "نشط";
            }
            else
            {
                chk_State.ForeColor = Color.Red;
                chk_State.Text = "غير نشط";
            }
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv.RowCount > 0)
                {
                    int vID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    vTblMainCash = cmdMainCash.GetAll().FirstOrDefault(id => id.MainCash_ID == vID);

                    txt_ID.Text = vTblMainCash.MainCash_ID.ToString();
                    txt_Name.Text = vTblMainCash.MainCash_Name;
                    txt_Balance.Value = (decimal)vTblMainCash.MainCash_Balance;
                    txt_S_Balance.Value = (decimal)vTblMainCash.MainCash_S_Balance;
                    txt_Z_Balance.Value = (decimal)vTblMainCash.MainCash_Z_Balance;
                    txt_Notes.Text = vTblMainCash.MainCash_Note;
                    chk_State.Checked = (bool)vTblMainCash.MainCash_State;
                    dtp_S_Date.Value = (DateTime)vTblMainCash.MainCash_S_Date;
                    cmbBranch.SelectedIndex = cmbBranch.FindString(vTblMainCash.TBL_Branch. Branch_Name);
                }
            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في اختيار البيانات", frmNotifications.enmType.vError);
            }
        }

        private void frmTreasure_MainCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1) fnClear_Data();
            else if (e.KeyData == Keys.F2) fnSave();
            else if (e.KeyData == Keys.Delete) fnDelet();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fnClear_Data();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fnSave();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            fnDelet();
        }
    }
}
