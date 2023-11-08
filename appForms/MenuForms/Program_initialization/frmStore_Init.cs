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
    public partial class frmStore_Init : Form
    {

        #region Variable
        clsCommander<TBL_Store> cmdStore = new clsCommander<TBL_Store>();
        TBL_Store vTblStore = new TBL_Store();

        clsCommander<TBL_Store_Branch> cmdStore_Branch = new clsCommander<TBL_Store_Branch>();
        TBL_Store_Branch vTblStore_Branch = new TBL_Store_Branch();
        
        clsCommander<TBL_Branch> cmdBranch = new clsCommander<TBL_Branch>();
        TBL_Branch vTblBranch = new TBL_Branch();

        #endregion


        #region Constructor
        public frmStore_Init()
        {
            InitializeComponent();
        }
        #endregion


        #region FormLoad
        private void frmStore_Init_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgv);
            fnGrt_Branch();
            fnClear_Data();
        }
        #endregion


        #region Functions
        public int fnMax_ID_Store()
        {
            var x = cmdStore.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLastRow = cmdStore.GetAll().FirstOrDefault(id => id.Store_ID == cmdStore.GetAll().Max(mID => mID.Store_ID));
                var vLastID = vLastRow.Store_ID;
                return vLastID + 1;
            }
            else return 1;
        }
        
        public int fnMax_ID_Store_Branch()
        {
            var x = cmdStore_Branch.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLastRow = cmdStore_Branch.GetAll().FirstOrDefault(id => id.Store_Branch_ID == cmdStore_Branch.GetAll().Max(mID => mID.Store_Branch_ID));
                var vLastID = vLastRow.Store_Branch_ID;
                return vLastID + 1;
            }
            else return 1;
        }

        public void fnFill_GV()
        {
            try
            {
                

                dgv.DataSource = (from vStore_Branch in cmdStore_Branch.GetAll().Where(id => id.Store_Branch_State == true) 
                                  join vStore in cmdStore.GetAll() on vStore_Branch.Store_ID equals vStore.Store_ID
                                  select new
                                  {
                                      ID = vStore_Branch.Store_Branch_ID,
                                      Name = vStore.Store_Name,
                                      Location = vStore.Store_Location,
                                      Date = vStore.Store_S_Date,
                                      Branch = vStore_Branch.TBL_Branch.Branch_Name,
                                      Note = vStore.Store_Notes,
                                  }).ToList();

                dgv.Columns["ID"].HeaderText = "رقم";
                dgv.Columns["ID"].DisplayIndex = 0;

                dgv.Columns["Name"].HeaderText = "اسم";
                dgv.Columns["Name"].DisplayIndex = 1;

                dgv.Columns["Location"].HeaderText = "مكان المخزن";
                dgv.Columns["Location"].DisplayIndex = 2;

                dgv.Columns["Date"].HeaderText = "تاريخ الانشاء";
                dgv.Columns["Date"].DisplayIndex = 4;

                dgv.Columns["Branch"].HeaderText = "تابع للفرع";
                dgv.Columns["Branch"].DisplayIndex = 3;

                dgv.Columns["Note"].HeaderText = "ملاحظات";
                dgv.Columns["Note"].DisplayIndex = 5;


            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في عرض البيانات", frmNotifications.enmType.vError);
            }
        }

        public void fnGrt_Branch()
        {
            try
            {
                cmbBranch.DataSource = (from vBranch in cmdBranch.GetAll()
                                        select new
                                        {
                                            ID = vBranch.Branch_ID,
                                            Name = vBranch.Branch_Name
                                        }).ToList();
                cmbBranch.DisplayMember = "Name";
                cmbBranch.ValueMember= "ID";

            }
            catch
            {
                frmNotifications nfrm = new frmNotifications();
                nfrm.fnShowAlert("خطأ في عرض بيانات الفرع", frmNotifications.enmType.vError);
            }
        }
        public void fnClear_Data()
        {

            txt_ID.Text = Convert.ToString(fnMax_ID_Store());
            txtStore_Branch_ID.Text = fnMax_ID_Store_Branch().ToString();
            txt_Name.Text = "";
            txt_Notes.Text = "";
            txtLocation.Text = "";
            chk_State.Checked = true;
            cmbBranch.SelectedIndex = -1;
            dtp_S_Date.Value = DateTime.Now;

            fnFill_GV();
        }
        public bool fnValidation()
        {
            if (txt_ID.Text == "") return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_ID.Text, "[^0-9]")) return false;
            else if (txt_Name.Text == "") return false;
            else if (cmbBranch.SelectedIndex == -1) return false;
            else if (txtLocation.Text == "") return false;
            else return true;

        }
        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblStore = cmdStore.GetAll().FirstOrDefault(id => id.Store_ID == Convert.ToInt32(txt_ID.Text));
                    vTblStore_Branch = cmdStore_Branch.GetAll().FirstOrDefault(id=>id.Store_Branch_ID == Convert.ToInt32(txtStore_Branch_ID.Text));
                    vTblBranch = cmdBranch.GetAll().FirstOrDefault(id => id.Branch_Name == cmbBranch.Text);
                    if(vTblStore != null && vTblStore_Branch!=null)
                    {
                        vTblStore.Store_Name = txt_Name.Text;
                        vTblStore.Store_Location = txtLocation.Text;
                        vTblStore.Store_Notes = txt_Notes.Text;
                        vTblStore.Store_S_Date = Convert.ToDateTime(string.Format(dtp_S_Date.Value.ToShortDateString(), "MM/dd/yyyy"));
                        vTblStore.Store_State = chk_State.Checked;
                        cmdStore.Update_Data(vTblStore);

                        vTblStore_Branch.Store_ID = Convert.ToInt32(txt_ID.Text);
                        vTblStore_Branch.Branch_ID = vTblBranch.Branch_ID;
                        vTblStore_Branch.Store_Branch_State = chk_State.Checked;
                        cmdStore_Branch.Update_Data(vTblStore_Branch);

                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم تعديل البيانات", frmNotifications.enmType.vSuccess);
                    }
                    else if(vTblStore == null && vTblStore_Branch == null)
                    {

                        vTblStore = new TBL_Store
                        {
                            Store_ID = Convert.ToInt32(txt_ID.Text),
                            Store_Name = txt_Name.Text,
                            Store_Location = txtLocation.Text,
                            Store_Notes = txt_Notes.Text,
                            Store_S_Date = Convert.ToDateTime(string.Format(dtp_S_Date.Value.ToShortDateString(), "MM/dd/yyyy")),
                            Store_State = chk_State.Checked
                        };
                        cmdStore.Insert_Data(vTblStore);


                        vTblStore_Branch = new TBL_Store_Branch
                        {
                            Store_Branch_ID = Convert.ToInt32(txtStore_Branch_ID.Text),
                            Branch_ID = vTblBranch.Branch_ID,
                            Store_ID = Convert.ToInt32(txt_ID.Text),
                            Store_Branch_State = chk_State.Checked
                        };
                        cmdStore_Branch.Insert_Data(vTblStore_Branch);

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
                if (ex.Message.Contains("Store_Name_Index"))
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("لم يتم حفظ البيانات \n اسم المخزن مسجل مسبقا", frmNotifications.enmType.vError);
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
                if (vTblStore != null && vTblStore_Branch != null)
                {
                    var vResult = MessageBox.Show("هل تريد حذف المخزن", "تأكيد!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vResult == DialogResult.Yes)
                    {
                        vTblStore.Store_State = false;
                        cmdStore.Update_Data(vTblStore);
                        vTblStore_Branch.Store_Branch_State = false;
                        cmdStore_Branch.Update_Data(vTblStore_Branch);
                        fnClear_Data();

                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم حذف المخزن بنجاح", frmNotifications.enmType.vSuccess);
                    }
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("برجاء اختيار المخزن المراد حذفه", frmNotifications.enmType.vWarning);
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
            fnDelete();
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.RowCount > 0)
                {
                    int vID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    string vName = (dgv.CurrentRow.Cells[1].Value).ToString();

                    vTblStore_Branch = cmdStore_Branch.GetAll().FirstOrDefault(id => id.Store_Branch_ID == vID);
                    vTblStore = cmdStore.GetAll().FirstOrDefault(name => name.Store_Name == vName);

                    txt_ID.Text = vTblStore_Branch.Store_ID.ToString();
                    txt_Name.Text = vTblStore.Store_Name;
                    txtLocation.Text = vTblStore.Store_Location;
                    txt_Notes.Text = vTblStore.Store_Notes;
                    chk_State.Checked = (bool)vTblStore.Store_State;
                    dtp_S_Date.Value = (DateTime)vTblStore.Store_S_Date;

                    cmbBranch.SelectedIndex = cmbBranch.FindString(vTblStore_Branch.TBL_Branch.Branch_Name);
                    txtStore_Branch_ID.Text = vTblStore_Branch.Store_Branch_ID.ToString();


                }
            }
            catch
            {

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
    }
}
