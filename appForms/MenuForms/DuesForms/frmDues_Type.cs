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

namespace appFelxMax.appForms.MenuForms.DuesForms
{
    public partial class frmDues_Type : Form
    {

        #region Variable
        clsCommander<TBL_Dues_Type> cmdDues_T = new clsCommander<TBL_Dues_Type>();
        TBL_Dues_Type vTblDues_T = new TBL_Dues_Type();

        //clsCommander<TBL_Dues> cmdDues= new clsCommander<TBL_Dues>();
        //TBL_Dues vTblDues = new TBL_Dues();
        #endregion


        #region Constructor
        public frmDues_Type()
        {
            InitializeComponent();
        }
        #endregion

        #region FormLoad
        private void frmDues_Type_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgvDuesT);
            fnClear_Data();
        }
        #endregion

        #region Functions
        public int fnMax_ID_Type()
        {
            var x = cmdDues_T.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLastRow = cmdDues_T.GetAll().FirstOrDefault(id => id.Dues_T_ID == cmdDues_T.GetAll().Max(mID => mID.Dues_T_ID));
                var vLastID = vLastRow.Dues_T_ID;
                return vLastID + 1;
            }
            else return 1;
        }

        public void fnFill_GV()
        {
            dgvDuesT.DataSource = (from vDues_T in cmdDues_T.GetAll().Where(id=> id.Dues_T_State == true)
                                   select new
                                   {
                                       Dues_ID = vDues_T.Dues_T_ID,
                                       Dues_Name = vDues_T.Dues_T_Name,
                                       Dues_High_Price = vDues_T.Dues_High_Price,
                                       Dues_Note = vDues_T.Dues_T_Notes
                                   }).ToList();
            dgvDuesT.Columns["Dues_ID"].HeaderText = "رقم";
            dgvDuesT.Columns["Dues_ID"].DisplayIndex = 0;

            dgvDuesT.Columns["Dues_Name"].HeaderText = "اسم المصروف";
            dgvDuesT.Columns["Dues_Name"].DisplayIndex = 1;
            
            dgvDuesT.Columns["Dues_High_Price"].HeaderText = "القيمة العليا";
            dgvDuesT.Columns["Dues_High_Price"].DisplayIndex = 2;
            
            dgvDuesT.Columns["Dues_Note"].HeaderText = "ملاحظات";
            dgvDuesT.Columns["Dues_Note"].DisplayIndex =3;

        }
        public void fnClear_Data()
        {
            vTblDues_T = new TBL_Dues_Type();

            txtDuesT_ID.Text = fnMax_ID_Type().ToString();
            txtDuesT_Name.Text = "";
            txtDuesT_Note.Text = "";
            chkDuesT_State.Checked = true;
            txtDues_High_Price.Value = 0;
            fnFill_GV();
        }
        public bool fnValidation()
        {
            if (txtDuesT_ID.Text == "") return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtDuesT_ID.Text, "[^0-9]")) return false;
            else if (txtDuesT_Name.Text == "") return false;
            else return true;
        }
        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblDues_T = cmdDues_T.GetAll().Where(id => id.Dues_T_ID == Convert.ToInt32(txtDuesT_ID.Text)).FirstOrDefault();
                    //vTblDues = cmdDues.GetAll().Where(id => id.Dues_ID == Convert.ToInt32(txtDuesT_ID.Text)).FirstOrDefault();
                    if (vTblDues_T != null)
                    {
                        vTblDues_T.Dues_T_Name = txtDuesT_Name.Text;
                        vTblDues_T.Dues_T_Notes = txtDuesT_Note.Text;
                        vTblDues_T.Dues_T_State = chkDuesT_State.Checked;
                        vTblDues_T.Dues_High_Price= (float?)txtDues_High_Price.Value;
                        cmdDues_T.Update_Data(vTblDues_T);

                        //vTblDues.Dues_Name = txtDuesT_Name.Text;
                        //vTblDues.Dues_Notes = txtDuesT_Note.Text;
                        //vTblDues.Dues_State = chkDuesT_State.Checked;
                        //vTblDues.Dues_High_Price = (float?)txtDues_High_Price.Value;
                        //vTblDues.Dues_T_ID = vTblDues_T.Dues_T_ID;
                        //cmdDues.Update_Data(vTblDues);

                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم تعديل البيانات", frmNotifications.enmType.vSuccess);
                    }
                    else
                    {
                        vTblDues_T = new TBL_Dues_Type();
                        vTblDues_T.Dues_T_ID = Convert.ToInt32(txtDuesT_ID.Text);
                        vTblDues_T.Dues_T_Name = txtDuesT_Name.Text;
                        vTblDues_T.Dues_T_Notes = txtDuesT_Note.Text;
                        vTblDues_T.Dues_T_State = chkDuesT_State.Checked;
                        vTblDues_T.Dues_High_Price = (float?)txtDues_High_Price.Value;
                        cmdDues_T.Insert_Data(vTblDues_T);

                        //vTblDues = new TBL_Dues();
                        //vTblDues.Dues_ID = Convert.ToInt32(txtDuesT_ID.Text);
                        //vTblDues.Dues_Name = txtDuesT_Name.Text;
                        //vTblDues.Dues_Notes = txtDuesT_Note.Text;
                        //vTblDues.Dues_State = chkDuesT_State.Checked;
                        //vTblDues.Dues_High_Price = (float?)txtDues_High_Price.Value;
                        //vTblDues.Dues_T_ID = vTblDues_T.Dues_T_ID;
                        //cmdDues.Insert_Data(vTblDues);

                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم حفظ البيانات", frmNotifications.enmType.vSuccess);
                    }

                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("تأكد من إدخال البيانات كاملة", frmNotifications.enmType.vWarning);
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("Dues_Name_Index"))
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("لم يتم حفظ البيانات \n اسم المصروف مسجل مسبقا", frmNotifications.enmType.vError);
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
                if (vTblDues_T != null)
                {
                    var vResult = MessageBox.Show("هل تريد حذف هذا النوع", "تأكيد!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vResult == DialogResult.Yes)
                    {
                        vTblDues_T.Dues_T_State= false;
                        cmdDues_T.Update_Data(vTblDues_T);
                        fnClear_Data();

                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم حذف النوع بنجاح", frmNotifications.enmType.vSuccess);
                    }
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("برجاء اختيار النوع المراد حذفه", frmNotifications.enmType.vWarning);
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

        private void chkDuesT_State_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuesT_State.Checked == true)
            {
                chkDuesT_State.ForeColor = Color.Green;
                chkDuesT_State.Text = "نشط";
            }
            else
            {
                chkDuesT_State.ForeColor = Color.Red;
                chkDuesT_State.Text = "غير نشط";
            }
        }

        private void dgvDuesT_Click(object sender, EventArgs e)
        {
            if (dgvDuesT.RowCount > 0)
            {
                try
                {
                    int vID = Convert.ToInt32(dgvDuesT.CurrentRow.Cells[0].Value);

                    vTblDues_T = cmdDues_T.GetAll().FirstOrDefault(id => id.Dues_T_ID == vID);

                    txtDuesT_ID.Text = vTblDues_T.Dues_T_ID.ToString();
                    txtDuesT_Name.Text = vTblDues_T.Dues_T_Name;
                    txtDuesT_Note.Text = vTblDues_T.Dues_T_Notes;
                    chkDuesT_State.Checked = (bool)vTblDues_T.Dues_T_State;
                    txtDues_High_Price.Value = (decimal)vTblDues_T.Dues_High_Price;
                }
                catch
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("خطأ في اختيار البيانات", frmNotifications.enmType.vError);
                }
            }
        }

        private void txtDuesT_ID_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtDuesT_ID.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("برجاء ادخال ارقام فقط");
            //    txtDuesT_ID.Text = "";
            //}
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fnClear_Data();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fnSave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnDelete();
        }

        private void frmDues_Type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1) fnClear_Data();
            else if (e.KeyData == Keys.F2) fnSave();
            else if (e.KeyData == Keys.Delete) fnDelete();
            else if (e.KeyData == Keys.Escape) this.Close();

        }
    }
}
