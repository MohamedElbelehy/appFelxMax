using appFelxMax.appClass.clsProgOptions;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace appFelxMax.appForms.ServerForms
{
    public partial class frmActivation : Form
    {
        public frmActivation()
        {
            InitializeComponent();
        }

        private void frmActivation_Load(object sender, EventArgs e)
        {
            clsCopyDetails clsCopyDetails = new clsCopyDetails();
            clsCopyDetails.GetMACAddress(txtMacAddress);
        }
    }
}
