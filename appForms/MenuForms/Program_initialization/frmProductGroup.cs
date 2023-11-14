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

namespace appFelxMax.appForms.MenuForms.Program_initialization
{
    public partial class frmProductGroup : Form
    {
        #region Variable
        clsCommander<TBL_Product_Group> cmdProduct_Group = new clsCommander<TBL_Product_Group>();
        TBL_Product_Group vTblProduct_Group = new TBL_Product_Group();
        #endregion


        #region Constructor
        public frmProductGroup()
        {
            InitializeComponent();
        }
        #endregion


        #region FormLoad
        private void frmProduct_Group_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgv);
            fnClear_Data();
        }
        #endregion


        #region Functions
        public int fnMax_ID()
        {

            var x = cmdProduct_Group.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLastRow = cmdProduct_Group.GetAll().FirstOrDefault(id => id.Pro_Group_ID == cmdProduct_Group.GetAll().Max(mID => mID.Pro_Group_ID));
                var vLastID = vLastRow.Pro_Group_ID;
                return vLastID + 1;
            }
            else return 1;

        }

        public void fnFill_GV()
        {
            dgv.DataSource = (from vUnit in cmdProduct_Group.GetAll()
                              select new
                              {
                                  ID = vUnit.Pro_Group_ID,
                                  Name = vUnit.Pro_Group_Name,
                              }).ToList();
            dgv.Columns["ID"].HeaderText = "رقم";
            dgv.Columns["Name"].HeaderText = "اسم";
        }

        public void fnClear_Data()
        {
            txt_ID.Text = fnMax_ID().ToString();
            txt_Name.Text = "";
            chk_State.Checked = true;
            fnFill_GV();
        }

        public bool fnValidation()
        {
            if (txt_ID.Text == "") return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_ID.Text, "[^0-9]")) return false;
            else if (txt_Name.Text == "") return false;
            else return true;
        }
        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblProduct_Group = cmdProduct_Group.GetAll().FirstOrDefault(id => id.Pro_Group_ID == Convert.ToInt32(txt_ID.Text));
                    if (vTblProduct_Group != null)
                    {
                        vTblProduct_Group.Pro_Group_Name = txt_Name.Text;
                        vTblProduct_Group.Pro_Group_State= chk_State.Checked;
                        cmdProduct_Group.Update_Data(vTblProduct_Group);
                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم تعديل البيانات", frmNotifications.enmType.vSuccess);
                    }
                    else
                    {
                        vTblProduct_Group = new TBL_Product_Group()
                        {
                            Pro_Group_ID = fnMax_ID(),
                            Pro_Group_Name = txt_Name.Text,
                            Pro_Group_State = chk_State.Checked
                        };
                        cmdProduct_Group.Insert_Data(vTblProduct_Group);
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
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unit_Name_Index"))
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("لم يتم حفظ البيانات \n اسم الوحدة مسجل مسبقا", frmNotifications.enmType.vError);
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("خطأ في حفظ البيانات", frmNotifications.enmType.vError);
                }

            }
        }

        public void fnDelet()
        {
            try
            {
                if (vTblProduct_Group != null)
                {
                    var vResult = MessageBox.Show("هل تريد حذف الوحدة", "تأكيد!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vResult == DialogResult.Yes)
                    {
                        vTblProduct_Group.Pro_Group_State = false;
                        cmdProduct_Group.Update_Data(vTblProduct_Group);
                        fnClear_Data();

                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم حذف الوحدة بنجاح", frmNotifications.enmType.vSuccess);
                    }
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("برجاء اختيار الوحدة المراد حذفها", frmNotifications.enmType.vWarning);
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

        private void dgv_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.RowCount > 0)
                {
                    int vID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    vTblProduct_Group = cmdProduct_Group.GetAll().FirstOrDefault(id => id.Pro_Group_ID == vID);
                    txt_ID.Text = vTblProduct_Group.Pro_Group_ID.ToString();
                    txt_Name.Text = vTblProduct_Group.Pro_Group_Name;
                    chk_State.Checked = (bool)vTblProduct_Group.Pro_Group_State;
                }
            }
            catch
            {

            }
        }

        private void frmProduct_Group_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1) fnClear_Data();
            else if (e.KeyData == Keys.F2) fnSave();
            else if (e.KeyData == Keys.Delete) fnDelet();
            else if (e.KeyData == Keys.Escape) this.Close();
        }
    }
}
