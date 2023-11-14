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


    public partial class frmAddEmp : Form
    {
        #region Variable
        clsCommander<TBL_Employee> cmdEmployee = new clsCommander<TBL_Employee>();
        TBL_Employee vTblEmployee = new TBL_Employee();

        clsCommander<TBL_Employee_Account> cmdEmployee_Account = new clsCommander<TBL_Employee_Account>();
        TBL_Employee_Account vTblEmployee_Account = new TBL_Employee_Account();
        #endregion


        #region Constructor
        public frmAddEmp()
        {
            InitializeComponent();
        }



        #endregion

        #region FormLoad
        private void frmAddEmp_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Functions
        public int fnMax_ID()
        {
            try
            {
                var x = cmdEmployee.GetAll().ToList();
                if (x.Count != 0)
                {
                    var vLRow = cmdEmployee.GetAll().FirstOrDefault(id => id.Emp_ID == cmdEmployee.GetAll().Max(mid => mid.Emp_ID));
                    var vLID = vLRow.Emp_ID + 1;
                    return vLID;
                }
                else return 1;
            }
            catch
            {
                return 0;
            }
        }

        public void fnGet_Branch()
        {
            
        }


        #endregion

        #region Events

        #endregion


    }
}
