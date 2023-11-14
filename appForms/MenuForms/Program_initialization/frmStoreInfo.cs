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
    public partial class frmStoreInfo : Form
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
        public frmStoreInfo()
        {
            InitializeComponent();
        }
        #endregion


        #region FormLoad
        private void frmStore_Init_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgvStores);
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
                

                dgvStores.DataSource = (from vStore_Branch in cmdStore_Branch.GetAll().Where(id => id.Store_Branch_State == true) 
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

                dgvStores.Columns["ID"].HeaderText = "رقم";
                dgvStores.Columns["ID"].DisplayIndex = 0;

                dgvStores.Columns["Name"].HeaderText = "اسم";
                dgvStores.Columns["Name"].DisplayIndex = 1;

                dgvStores.Columns["Location"].HeaderText = "مكان المخزن";
                dgvStores.Columns["Location"].DisplayIndex = 2;

                dgvStores.Columns["Date"].HeaderText = "تاريخ الانشاء";
                dgvStores.Columns["Date"].DisplayIndex = 4;

                dgvStores.Columns["Branch"].HeaderText = "تابع للفرع";
                dgvStores.Columns["Branch"].DisplayIndex = 3;

                dgvStores.Columns["Note"].HeaderText = "ملاحظات";
                dgvStores.Columns["Note"].DisplayIndex = 5;


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

            txtStoreID.Text = Convert.ToString(fnMax_ID_Store());
            txtStoreName.Text = "";
            chkStoreState.Checked = true;
            cmbBranch.SelectedIndex = -1;
            dtpStore_S_Date.Value = DateTime.Now;

            fnFill_GV();
        }
        public bool fnValidation()
        {
            if (txtStoreID.Text == "") return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtStoreID.Text, "[^0-9]")) return false;
            else if (txtStoreName.Text == "") return false;
            else if (cmbBranch.SelectedIndex == -1) return false;
            else return true;

        }
        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblStore = cmdStore.GetAll().FirstOrDefault(id => id.Store_ID == Convert.ToInt32(txtStoreID.Text));
                    vTblBranch = cmdBranch.GetAll().FirstOrDefault(id => id.Branch_Name == cmbBranch.Text);
                    if(vTblStore != null && vTblStore_Branch!=null)
                    {
                        vTblStore.Store_Name = txtStoreName.Text;
                        vTblStore.Store_S_Date = Convert.ToDateTime(string.Format(dtpStore_S_Date.Value.ToShortDateString(), "MM/dd/yyyy"));
                        vTblStore.Store_State = chkStoreState.Checked;
                        cmdStore.Update_Data(vTblStore);

                        vTblStore_Branch.Store_ID = Convert.ToInt32(txtStoreID.Text);
                        vTblStore_Branch.Branch_ID = vTblBranch.Branch_ID;
                        vTblStore_Branch.Store_Branch_State = chkStoreState.Checked;
                        cmdStore_Branch.Update_Data(vTblStore_Branch);

                        fnClear_Data();
                        frmNotifications nfrm = new frmNotifications();
                        nfrm.fnShowAlert("تم تعديل البيانات", frmNotifications.enmType.vSuccess);
                    }
                    else if(vTblStore == null && vTblStore_Branch == null)
                    {

                        vTblStore = new TBL_Store
                        {
                            Store_ID = Convert.ToInt32(txtStoreID.Text),
                            Store_Name = txtStoreName.Text,
                            Store_S_Date = Convert.ToDateTime(string.Format(dtpStore_S_Date.Value.ToShortDateString(), "MM/dd/yyyy")),
                            Store_State = chkStoreState.Checked
                        };
                        cmdStore.Insert_Data(vTblStore);


                        vTblStore_Branch = new TBL_Store_Branch
                        {
                            Branch_ID = vTblBranch.Branch_ID,
                            Store_ID = Convert.ToInt32(txtStoreID.Text),
                            Store_Branch_State = chkStoreState.Checked
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

        private void dgvStores_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStores.RowCount > 0)
                {
                    int vID = Convert.ToInt32(dgvStores.CurrentRow.Cells[0].Value);
                    string vName = (dgvStores.CurrentRow.Cells[1].Value).ToString();

                    vTblStore_Branch = cmdStore_Branch.GetAll().FirstOrDefault(id => id.Store_Branch_ID == vID);
                    vTblStore = cmdStore.GetAll().FirstOrDefault(name => name.Store_Name == vName);

                    txtStoreID.Text = vTblStore_Branch.Store_ID.ToString();
                    txtStoreName.Text = vTblStore.Store_Name;
                    chkStoreState.Checked = (bool)vTblStore.Store_State;
                    dtpStore_S_Date.Value = (DateTime)vTblStore.Store_S_Date;
                    cmbBranch.SelectedIndex = cmbBranch.FindString(vTblStore_Branch.TBL_Branch.Branch_Name);
                }
            }
            catch
            {

            }
        }

        private void chkStoreState_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStoreState.Checked == true)
            {
                chkStoreState.ForeColor = Color.Green;
                chkStoreState.Text = "نشط";
            }
            else
            {
                chkStoreState.ForeColor = Color.Red;
                chkStoreState.Text = "غير نشط";
            }
        }
    }
}
