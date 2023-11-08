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
using appFelxMax.appForms.OtherForms;

namespace appFelxMax.appForms.SubForms
{
    public partial class frmAdd_Vendor : Form
    {

        #region Variable
        clsCommander<TBL_Supplier> cmdSup = new clsCommander<TBL_Supplier>();
        TBL_Supplier vTblSup = new TBL_Supplier();
        #endregion

        #region Constructor

        public frmAdd_Vendor()
        {
            InitializeComponent();
        }

        #endregion

        #region FormLoad
        private void frmAdd_Vendor_Load(object sender, EventArgs e)
        {
            fnClear_Data();
        }
        #endregion

        #region Functions
        public int fnMax_ID()
        {
            var x = cmdSup.GetAll().ToList();
            if (x.Count != 0)
            {
                var vLast_Row = cmdSup.GetAll().Where(id => id.Sup_ID == cmdSup.GetAll().Max(mID => mID.Sup_ID)).FirstOrDefault();
                int vLast_ID = vLast_Row.Sup_ID;
                return vLast_ID + 1;
            }
            else return 1;
        }

        public void fnClear_Data()
        {
            txtVend_ID.Text = fnMax_ID().ToString();
            txtVend_Name.Text = "";
            txtVend_Mobil.Text = "";
            txtVend_Code.Text =  fnMax_ID().ToString() + string.Format(DateTime.Now.Day.ToString()) + string.Format(DateTime.Now.Year.ToString());
            txtVend_Address.Text = "";
            dtpVend_S_Date.Value = DateTime.Now;
        }

        public bool fnValidation()
        {
            if (txtVend_ID.Text == "") return false;
            else if (txtVend_Code.Text == "") return false;
            else if (txtVend_Mobil.Text == "") return false;
            else if (txtVend_Name.Text == "") return false;
            else return true;
        }

        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblSup = cmdSup.GetAll().Where(id => id.Sup_ID == Convert.ToInt32(txtVend_ID.Text)).FirstOrDefault();
                    if (vTblSup != null)
                    {
                        vTblSup.Sup_Code = Convert.ToInt32(txtVend_Code.Text);
                        vTblSup.Sup_Name = txtVend_Name.Text;
                        vTblSup.Sup_Mobile = txtVend_Mobil.Text;
                        vTblSup.Sup_Address = txtVend_Address.Text;
                        vTblSup.Sup_S_Date = dtpVend_S_Date.Value;
                        vTblSup.Sup_State = chkVend_State.Checked;
                        vTblSup.Sup_Note = txtVend_Notes.Text;
                        cmdSup.Update_Data(vTblSup);
                    }
                    else
                    {
                        vTblSup = new TBL_Supplier
                        {
                            Sup_ID = Convert.ToInt32(txtVend_ID.Text),
                            Sup_Code = Convert.ToInt32(txtVend_Code.Text),
                            Sup_Name = txtVend_Name.Text,
                            Sup_Mobile = txtVend_Mobil.Text,
                            Sup_Address = txtVend_Address.Text,
                            Sup_S_Date = dtpVend_S_Date.Value,
                            Sup_State = chkVend_State.Checked,
                            Sup_Note = "-"
                        };
                        cmdSup.Insert_Data(vTblSup);
                    }
                    fnClear_Data();
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("تم حفظ البيانات", frmNotifications.enmType.vSuccess);
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("تأكد من إدخال البيانات المطلوبة", frmNotifications.enmType.vWarning);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Sup_Name_Index"))
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("لم يتم حفظ البيانات \n اسم المورد مسجل مسبقا", frmNotifications.enmType.vError);
                }
                else
                {
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("لم يتم حفظ البيانات", frmNotifications.enmType.vError);
                }
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

        private void frmAdd_Vendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                fnClear_Data();
            }
            else if (e.KeyData == Keys.F2)
            {
                fnSave();
            }
            else if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void chkVend_State_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVend_State.Checked)
            {
                chkVend_State.Text = "نشط";
                chkVend_State.ForeColor = Color.Green;
            }
            else
            {
                chkVend_State.Text = "غير نشط";
                chkVend_State.ForeColor = Color.Red;
            }
        }
    }
}
