using appFelxMax.appForms.SubForms;
using System;
using System.Windows.Forms;

namespace appFelxMax.appForms.MenuForms.AccountForms
{
    public partial class frmVendors : Form
    {
        public frmVendors()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAdd_Vendor frmAdd_Vendor = new frmAdd_Vendor();
            frmAdd_Vendor.ShowDialog();
        }
    }
}
