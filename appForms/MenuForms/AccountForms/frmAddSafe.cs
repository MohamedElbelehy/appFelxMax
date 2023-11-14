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
    public partial class frmAddSafe : Form
    {
        #region Variable
        clsCommander<TBL_MainCash> cmdSafe = new clsCommander<TBL_MainCash>();
        TBL_MainCash vTblSafe= new TBL_MainCash();
        #endregion


        #region Constructor
        public frmAddSafe()
        {
            InitializeComponent();
        }



        #endregion

        #region FormLoad
        private void frmAddSafe_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Functions
        public int fnMax_ID()
        {
            try
            {
                var x = cmdSafe.GetAll().ToList();
                if (x.Count != 0)
                {
                    var vLRow = cmdSafe.GetAll().FirstOrDefault(id => id.MainCash_ID == cmdSafe.GetAll().Max(mid => mid.MainCash_ID));
                    var vLID = vLRow.MainCash_ID;
                    return vLID + 1;
                }
                else return 1;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region Events

        #endregion


    }
}
