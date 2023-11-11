using AAJGen;
using appFelxMax.appClass.clsProgOptions;
using System;
using System.Windows.Forms;

namespace appFelxMax.appForms.OtherForms
{
    public partial class frmCopyInfo : Form
    {
        public frmCopyInfo()
        {
            InitializeComponent();
        }

        private void frmCopyInfo_Load(object sender, EventArgs e)
        {
            // Load 
            fnLoad();

        }

        public void fnLoad()
        {
            // Class Details
            clsCopyDetails vclsCopyDetails = new clsCopyDetails();



            // get hdd sig
            vclsCopyDetails.fnGetHDD(txtCHDD);

            // get motherboard
            vclsCopyDetails.fnMotherboardInfo(txtCMotherboard);

            // get mac address
            txtCMAC.Text = clsCopyDetails.fnGetMacAddress().ToString();


        }

        private void btnChangeSig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برجاء الانتباه لهذه الخطوة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmMasterPassword vfrmMasterPassword = new frmMasterPassword();
            vfrmMasterPassword.vPassword = "1234";
            vfrmMasterPassword.ShowDialog();
            // Check Password
            if (!(vfrmMasterPassword.fnCheckPassword()))
            {
                return;
            }
            else
            {
                // Class Generate
                clsGenerate vclsGenerate = new clsGenerate();
                // Signature
                //vclsGenerate.fnResult(txtSignature.Text);
                RandomGen randomGen = new RandomGen();
                txtSignature.Text = randomGen.Gen(16);
                
            }
        }
    }
}
