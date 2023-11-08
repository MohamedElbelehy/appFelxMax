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
    public partial class frmUnits : Form
    {


        #region Variable
        clsCommander<TBL_Units> cmdUnit = new clsCommander<TBL_Units>();
        TBL_Units vTblUnit = new TBL_Units();
        #endregion


        #region Constructor
        public frmUnits()
        {
            InitializeComponent();
        }
        #endregion

        #region FormLoad
        private void frmUnits_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgv);
            fnClear_Data();
        }

        #endregion


        #region Functions
        public int fnMax_ID()
        {
            
            var x = cmdUnit.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLastRow = cmdUnit.GetAll().FirstOrDefault(id => id.Unit_ID == cmdUnit.GetAll().Max(mID => mID.Unit_ID));
                var vLastID = vLastRow.Unit_ID;
                return vLastID + 1;
            }
            else return 1;
            
        }

        public void fnFill_GV()
        {
            dgv.DataSource = (from vUnit in cmdUnit.GetAll()
                              select new
                              {
                                  ID = vUnit.Unit_ID,
                                  Name = vUnit.Unit_Name,
                                  Type = vUnit.Unit_Type,
                              }).ToList();
            dgv.Columns["ID"].HeaderText = "رقم";
            dgv.Columns["Name"].HeaderText = "اسم";
            dgv.Columns["Type"].HeaderText = "نوع";
        }

        public void fnClear_Data()
        {
            txt_ID.Text = fnMax_ID().ToString();
            txt_Name.Text = "";
            cmbType.Text = "";
            chk_State.Checked = true;
            fnFill_GV();
        }

        public bool fnValidation()
        {
            if (txt_ID.Text == "") return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_ID.Text, "[^0-9]")) return false;
            else if (txt_Name.Text == "") return false;
            else if (cmbType.Text == "") return false;
            else return true;
        }
        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblUnit = cmdUnit.GetAll().FirstOrDefault(id => id.Unit_ID == Convert.ToInt32(txt_ID.Text));
                    if(vTblUnit != null)
                    {
                        vTblUnit.Unit_Name = txt_Name.Text;
                        vTblUnit.Unit_Type = cmbType.Text;
                        vTblUnit.Unit_State = chk_State.Checked;
                        cmdUnit.Update_Data(vTblUnit);
                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم تعديل البيانات", frmNotifications.enmType.vSuccess);
                    }
                    else
                    {
                        vTblUnit = new TBL_Units()
                        {
                            Unit_ID = fnMax_ID(),
                            Unit_Name = txt_Name.Text,
                            Unit_Type = cmbType.Text,
                            Unit_State = chk_State.Checked
                        };
                        cmdUnit.Insert_Data(vTblUnit);
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
                if (vTblUnit != null)
                {
                    var vResult = MessageBox.Show("هل تريد حذف الوحدة", "تأكيد!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vResult == DialogResult.Yes)
                    {
                        vTblUnit.Unit_State = false;
                        cmdUnit.Update_Data(vTblUnit);
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

        private void dgv_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv.RowCount > 0)
                {
                    int vID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    vTblUnit = cmdUnit.GetAll().FirstOrDefault(id => id.Unit_ID == vID);
                    txt_ID.Text = vTblUnit.Unit_ID.ToString();
                    txt_Name.Text = vTblUnit.Unit_Name;
                    cmbType.Text = vTblUnit.Unit_Type;
                    chk_State.Checked = (bool)vTblUnit.Unit_State;
                }
            }
            catch
            {
                    
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

        private void button1_Click(object sender, EventArgs e)
        {
            fnDelet();
        }

        private void frmUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1) fnClear_Data();
            else if (e.KeyData == Keys.F2) fnSave();
            else if (e.KeyData == Keys.Delete) fnDelet();
            else if (e.KeyData == Keys.Escape) this.Close();
        }
    }
}
