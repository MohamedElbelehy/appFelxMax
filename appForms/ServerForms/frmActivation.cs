using AAJGen;
using appFelxMax.appClass.clsProgOptions;
using System;
using System.Collections.Generic;
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
            fnLoad();
        }

        public void fnLoad()
        {
            // Generate Signature
            RandomGen randomGen = new RandomGen();
            lblSignature.Text = randomGen.Gen(16);

            // Get Mac Address
            fnGetAdapter(cmbMacAddress); 

            // Generat Activation Code
            clsGenerate vclsGenerate = new clsGenerate();
            vclsGenerate.fnGenerateCode(txtOff);

        }

        public void fnGetAdapter(ComboBox comboBox)
        {
            List<string> AdapterList = new List<string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                AdapterList.Add(nic.Description);
            }
            comboBox.DataSource = AdapterList;
        }
    }
}
