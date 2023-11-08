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
    public partial class frmProduct_Section : Form
    {
        #region Variable
        clsCommander<TBL_Product_Sections> cmdProduct_Sections = new clsCommander<TBL_Product_Sections>();
        TBL_Product_Sections vTblProduct_Sections = new TBL_Product_Sections();

        clsCommander<TBL_Product_Group> cmdProduct_Group = new clsCommander<TBL_Product_Group>();
        TBL_Product_Group vTblProduct_Group = new TBL_Product_Group();

        #endregion


        #region Constructor
        public frmProduct_Section()
        {
            InitializeComponent();
        }
        #endregion


        #region FormLoad
        private void frmProduct_Section_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgv);
            fnGet_Product_Group();
            fnClear_Data();
        }
        #endregion


        #region Functions
        public int fnMax_ID()
        {

            var x = cmdProduct_Sections.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLastRow = cmdProduct_Sections.GetAll().FirstOrDefault(id => id.Pro_Section_ID == cmdProduct_Sections.GetAll().Max(mID => mID.Pro_Section_ID));
                var vLastID = vLastRow.Pro_Section_ID;
                return vLastID + 1;
            }
            else return 1;

        }

        public void fnFill_GV()
        {

            try
            {
                dgv.DataSource = (from vUnit in cmdProduct_Sections.GetAll().Where(id => id.Pro_Section_State == true)
                                  select new
                                  {
                                      ID = vUnit.Pro_Section_ID,
                                      Name = vUnit.Pro_Section_Name,
                                      Group = vUnit.TBL_Product_Group.Pro_Group_Name
                                  }).ToList();
                dgv.Columns["ID"].HeaderText = "رقم";
                dgv.Columns["Name"].HeaderText = "اسم";
                dgv.Columns["Group"].HeaderText = "المجموعة";
            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في عرض البيانات", frmNotifications.enmType.vError);
            }
        }
        public void fnGet_Product_Group()
        {
            cmbProductGroup.DataSource = (from vGroup in cmdProduct_Group.GetAll()
                                          select new
                                          {
                                              ID=vGroup .Pro_Group_ID,
                                              Name = vGroup.Pro_Group_Name,
                                          }).ToList();

            cmbProductGroup.DisplayMember = "Name";
            cmbProductGroup.ValueMember = "ID";
        }
        public void fnClear_Data()
        {
            txt_ID.Text = fnMax_ID().ToString();
            txt_Name.Text = "";
            chk_State.Checked = true;
            cmbProductGroup.SelectedIndex = -1;
            fnFill_GV();
        }

        public bool fnValidation()
        {
            if (txt_ID.Text == "") return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_ID.Text, "[^0-9]")) return false;
            else if (txt_Name.Text == "") return false;
            else if (cmbProductGroup.SelectedIndex == -1) return false;
            else return true;
        }
        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblProduct_Sections = cmdProduct_Sections.GetAll().FirstOrDefault(id => id.Pro_Group_ID == Convert.ToInt32(txt_ID.Text));
                    vTblProduct_Group = cmdProduct_Group.GetAll().FirstOrDefault(id => id.Pro_Group_Name == cmbProductGroup.Text);
                    if (vTblProduct_Sections != null)
                    {
                        vTblProduct_Sections.Pro_Section_Name = txt_Name.Text;
                        vTblProduct_Sections.Pro_Section_State = chk_State.Checked;
                        vTblProduct_Group.Pro_Group_ID = vTblProduct_Group.Pro_Group_ID;
                        cmdProduct_Sections.Update_Data(vTblProduct_Sections);
                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم تعديل البيانات", frmNotifications.enmType.vSuccess);
                    }
                    else
                    {
                        vTblProduct_Sections = new TBL_Product_Sections()
                        {
                            Pro_Section_ID = fnMax_ID(),
                            Pro_Section_Name = txt_Name.Text,
                            Pro_Section_State = chk_State.Checked,
                            Pro_Group_ID = vTblProduct_Group.Pro_Group_ID
                        };
                        cmdProduct_Sections.Insert_Data(vTblProduct_Sections);
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
                if (vTblProduct_Sections != null)
                {
                    var vResult = MessageBox.Show("هل تريد حذف القسم", "تأكيد!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vResult == DialogResult.Yes)
                    {
                        vTblProduct_Sections.Pro_Section_State = false;
                        cmdProduct_Sections.Update_Data(vTblProduct_Sections);
                        fnClear_Data();

                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم حذف القسم بنجاح", frmNotifications.enmType.vSuccess);
                    }
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("برجاء اختيار القسم المراد حذفه", frmNotifications.enmType.vWarning);
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
                if (dgv.RowCount > 0)
                {
                    int vID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    vTblProduct_Sections = cmdProduct_Sections.GetAll().FirstOrDefault(id => id.Pro_Section_ID == vID);
                    txt_ID.Text = vTblProduct_Group.Pro_Group_ID.ToString();
                    txt_Name.Text = vTblProduct_Group.Pro_Group_Name;
                    cmbProductGroup.SelectedIndex = cmbProductGroup.FindString(vTblProduct_Sections.TBL_Product_Group.Pro_Group_Name);
                    chk_State.Checked = (bool)vTblProduct_Group.Pro_Group_State;
                }
            }
            catch
            {

            }
        }
    }
}
