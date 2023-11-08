using appFelxMax.appForms.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFelxMax.appForms.MainForms
{
    public partial class frmCustVend : Form
    {
        public frmCustVend()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmRadio nFrm= new frmRadio();
            nFrm.ShowDialog();
        }
    }
}
