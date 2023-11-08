using appFelxMax.appClass.clsProgOptions;
using appFelxMax.appForms.OtherForms;
using appFelxMax.appForms.ServerForms;
using System;
using System.Media;
using System.Windows.Forms;

namespace appFelxMax.appForms.MainForms
{
    public partial class frmLogin : Form
    {
        // Verables 
        #region 

        // Copy Info 
        frmCopyInfo vfrmCopyInfo = new frmCopyInfo();
        // Sound player
        private SoundPlayer vIntro;



        #endregion

        // Constractor
        #region
        public frmLogin()
        {
            InitializeComponent();
            vIntro = new SoundPlayer("Intro.wav");
        }
        #endregion

        // Form Load
        #region

        private void frmLogin_Load(object sender, EventArgs e)
        {
            fnLoad();
        }

        #endregion

        // Functions 
        #region


        // Load 
        private void fnLoad()
        {
            pnlSide.Width = 15;
            lblIPV4.Visible = false;
        }

        // IPV4 
        // Get IPV4
        public void fnIPV4(Label label)
        {
            clsCopyDetails vcls_PCInfo = new clsCopyDetails();
            vcls_PCInfo.fnGetIPV4(lblIPV4);
        }


        #endregion

        // Events
        #region

        // Copy Info
        private void btnCopyInfo_Click(object sender, EventArgs e)
        {
            vfrmCopyInfo.ShowDialog();
            vfrmCopyInfo.StartPosition = FormStartPosition.CenterParent;
        }

        // Closing
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Sound Start
            //vIntro.Play();
            // Main Form
            frmMain vfrmMain = new frmMain();
            vfrmMain.ShowDialog();
        }
        
        // Server Form
        private void cmsServer_Click(object sender, EventArgs e)
        {
            // Show Password Form
            frmMasterPassword vfrmMasterPassword = new frmMasterPassword();
            // Set Password
            vfrmMasterPassword.vPassword = "1234";
            vfrmMasterPassword.ShowDialog();
            // Check Password
            if (!(vfrmMasterPassword.fnCheckPassword()))
            {
                return;
            }
            else
            {
                frmServerSettings vfrmServerSettings = new frmServerSettings();
                vfrmServerSettings.ShowDialog();
            }
        }

        // Activation Form
        private void cmsAtivation_Click(object sender, EventArgs e)
        {
            frmActivation vfrmActivation = new frmActivation();
            vfrmActivation.ShowDialog();
        }


        #endregion

        private void pnlSide_DoubleClick(object sender, EventArgs e)
        {
            // Design slidding panel
            if (pnlSide.Text == "")
            {
                pnlSide.Width = 15;
                pnlSide.Text = "-";
                lblIPV4.Visible = false;
            }
            else if (pnlSide.Text == "-")
            {
                pnlSide.Width = 200;
                pnlSide.Text = "";
                lblIPV4.Visible = true;
                fnIPV4(lblIPV4);
            }
        }
    }
}
