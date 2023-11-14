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
    public partial class frmCustomers : Form
    {
        #region Variable
        clsCommander<TBL_Customer_Account> cmdCust_Acc= new clsCommander<TBL_Customer_Account>();
        TBL_Customer_Account vTblCust_Acc = new TBL_Customer_Account();

        #endregion


        #region Constructor
        public frmCustomers()
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
