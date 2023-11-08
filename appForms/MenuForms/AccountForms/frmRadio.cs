using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFelxMax.appForms.SubForms
{
    public partial class frmRadio : Form
    {

        #region Variables

        #endregion

        #region Constructor

        public frmRadio()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        #endregion

        #region FormLoad
        private void frmRadio_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Functions
        public void fnOpenForm()
        {
            if (rdoCust.Checked)
            {
                this.Close();
                frmAdd_Cust nfrmCust = new frmAdd_Cust();
                nfrmCust.ShowDialog();
            }
            else
            {
                this.Close();
                frmAdd_Vendor nfrmVend = new frmAdd_Vendor();
                nfrmVend.ShowDialog();
            }
        }
        #endregion

        #region Events

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCust.Checked) 
            {
                rdoCust.ForeColor = Color.Green;
                rdoVend.ForeColor = Color.Black;
            }else
            {
                rdoCust.ForeColor = Color.Black;
                rdoVend.ForeColor = Color.Green;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fnOpenForm();
        }






        #endregion

        private void frmRadio_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                fnOpenForm();
            }
        }
    }
}
