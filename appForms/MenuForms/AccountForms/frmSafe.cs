﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFelxMax.appForms.MenuForms.AccountForms
{
    public partial class frmSafe : Form
    {
        public frmSafe()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAdd_Safe frmAdd_Safe = new frmAdd_Safe();
            frmAdd_Safe.ShowDialog();
        }
    }
}
