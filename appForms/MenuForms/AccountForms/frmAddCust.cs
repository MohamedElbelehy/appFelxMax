using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexMax_db;
using FlexMax_db.Commander;
using appFelxMax.appForms.OtherForms;

namespace appFelxMax.appForms.SubForms
{
    public partial class frmAdd_Cust : Form
    {

        #region Variable
        clsCommander<TBL_Customer> cmdCust = new clsCommander<TBL_Customer>();
        TBL_Customer vTblCust = new TBL_Customer();

        #endregion

        #region Constructor

        public frmAdd_Cust()
        {
            InitializeComponent();
            KeyPreview = true;

        }
        #endregion

        #region FormLoad

        private void frmAdd_Cust_Load(object sender, EventArgs e)
        {
            fnClear_Data();
        }
        #endregion

        #region Functions
        public int fnMax_ID()
        {
            var Row = cmdCust.GetAll().ToList();
            if (Row.Count != 0)
            {
                var vLastRow = cmdCust.GetAll().Where(id => id.Cust_ID == cmdCust.GetAll().Max(CustId => CustId.Cust_ID)).FirstOrDefault();
                int vMaxID = vLastRow.Cust_ID;
                return vMaxID + 1;
            }
            else return 1;
        }

        public void fnClear_Data()
        {
            txtCust_ID.Text = fnMax_ID().ToString();
            txtCust_Name.Text = "";
            txtCust_Balance.Text = "";
            txtCust_Code.Text =  fnMax_ID().ToString() + string.Format(DateTime.Now.Month.ToString()) + string.Format(DateTime.Now.Year.ToString());
            txtCust_Phone.Text = "";
            dtpCust_S_Date.Value = DateTime.Now;
        }

        public bool fnValidation()
        {
            if (txtCust_ID.Text == "") return false;
            else if (txtCust_Code.Text == "") return false;
            else if (txtCust_Balance.Text == "") return false;
            else if (txtCust_Name.Text == "") return false;
            else return true;
        }

        public void fnSave()
        {
            try
            {
                if (fnValidation())
                {
                    vTblCust = cmdCust.GetAll().Where(id => id.Cust_ID == Convert.ToInt32(txtCust_ID.Text)).FirstOrDefault();
                    if (vTblCust != null)
                    {
                        vTblCust.Cust_ID = Convert.ToInt32(txtCust_ID.Text);
                        vTblCust.Cust_Code = Convert.ToInt32(txtCust_Code.Text);
                        vTblCust.Cust_Name = txtCust_Name.Text;
                        vTblCust.Cust_Mobile = txtCust_Balance.Text;
                        vTblCust.Cust_Address = txtCust_Phone.Text;
                        vTblCust.Cust_S_Date = dtpCust_S_Date.Value;
                        vTblCust.Cust_State = chkCust_State.Checked;
                        vTblCust.Cust_Note = txtCust_Notes.Text;
                        cmdCust.Update_Data(vTblCust);
                    }
                    else
                    {
                        vTblCust = new TBL_Customer
                        {
                            Cust_ID = Convert.ToInt32(txtCust_ID.Text),
                            Cust_Code = Convert.ToInt32(txtCust_Code.Text),
                            Cust_Name = txtCust_Name.Text,
                            Cust_Mobile = txtCust_Balance.Text,
                            Cust_Address = txtCust_Phone.Text,
                            Cust_S_Date = dtpCust_S_Date.Value,
                            Cust_State = chkCust_State.Checked,
                            Cust_Note = "-"
                        };
                        cmdCust.Insert_Data(vTblCust);
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
            } catch(Exception ex)
            {
                if (ex.Message.Contains("Cust_Name_Index")) 
                { 
                    frmNotifications nfrm = new frmNotifications();
                    nfrm.fnShowAlert("لم يتم حفظ البيانات \n اسم العميل مسجل مسبقا", frmNotifications.enmType.vError);
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
        private void frmAdd_Cust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                fnSave();
            }
            else if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyData == Keys.F1) fnClear_Data();
        }

        private void chkCust_State_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCust_State.Checked)
            {
                chkCust_State.Text = "نشط";
                chkCust_State.ForeColor = Color.Green;
            }
            else
            {
                chkCust_State.Text = "غير نشط";
                chkCust_State.ForeColor = Color.Red;
            }
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            
        }

    }
}
