using System;
using System.Windows.Forms;

namespace appFelxMax.appForms.OtherForms
{
    public partial class frmMasterPassword : Form
    {

        // Proberty
        public string vPassword { get; set; }

        public frmMasterPassword()
        {
            InitializeComponent();
        }


        // Check Password
        public bool fnCheckPassword()
        {
            if (txtPass.Text == vPassword)
            {
                return true;
            }
            else
            {
                epPassword.SetError(this.txtPass, "كلمة المرور خطأ");
                txtPass.Clear();
                return false;
            }
        }

        // Button OK 
        private void btnOK_Click(object sender, EventArgs e)
        {
           if( fnCheckPassword())
            {
                this.Close();
            }
        }

    }
}
