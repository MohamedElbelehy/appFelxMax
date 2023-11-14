using FlexMax_db;
using FlexMax_db.Commander;
using System;
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
    public partial class frmExpenses : Form
    {
        #region Variable
        clsCommander<TBL_Dues> cmdDuesT = new clsCommander<TBL_Dues>();
        TBL_Dues vTblDues = new TBL_Dues();
        #endregion


        #region Constructor
        public frmExpenses()
        {
            InitializeComponent();
        }
        #endregion


        #region FormLoad

        #endregion


        #region Functions

        #endregion


        #region Events

        #endregion

    }
}
