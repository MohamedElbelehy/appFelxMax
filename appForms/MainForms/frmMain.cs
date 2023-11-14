using appFelxMax.appForms.MenuForms;
using System;
using System.Windows.Forms;
using appFelxMax.appClass.clsDesign;
using appFelxMax.appForms.OtherForms;
using appFelxMax.appForms.MenuForms.AccountForms;
using appFelxMax.appForms.MenuForms.Program_initialization;

namespace appFelxMax.appForms.MainForms
{
    public partial class frmMain : Form
    {

        // Virables
        #region

        

        #endregion

        // Constractor
        #region

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        // Form Load
        #region 
        private void frmMain_Load(object sender, EventArgs e)
        {
            fnCustomizeDesign();
        }
        #endregion

        // Functions
        #region

        //Drop Down List
        #region DropDownList
        private void fnCustomizeDesign()
        {
            pnlBills.Height = 35;
            pnlAccounting.Height = 35;
            pnlGeneral.Height = 35;
        }
        private void fnHidePNL()
        {
            // Bills
            if (pnlBills.Height == 155)
                pnlBills.Height = 35;
            // Accoutns
            if (pnlAccounting.Height == 155)
                pnlAccounting.Height = 35;
            // General
            if (pnlGeneral.Height == 155)
                pnlGeneral.Height = 35;
        }
        private void ShowPNL(Panel drop)
        {
            if (drop.Height == 155)
            {
                fnHidePNL();
                drop.Height = 35;
            }
            else
                drop.Height = 155;
        }
        #endregion
        //End Drop Down List


        #endregion

        // Events
        #region

        // Closing
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        //Slide Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Design slidding panel
            if (lblHome.Text == "القائمة الرئيسية")
            {
                pnlSlide.Width = 45;
                lblHome.Text = "القائمة";
            }
            else if (lblHome.Text == "القائمة")
            {
                pnlSlide.Width = 200;
                lblHome.Text = "القائمة الرئيسية";
            }
        }


        // Company Info 
        private void mnuCompanyInfo_Click(object sender, EventArgs e)
        {
            frmCompanyInfo vfrmCompanyInfo = new frmCompanyInfo();
            vfrmCompanyInfo.ShowDialog();
        }

        // Logout
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        // Bills Button

        private void btnBills_Click(object sender, EventArgs e)
        {

           ShowPNL(pnlBills);
        }

        // Account Button
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            ShowPNL(pnlAccounting);
        }

        // General Button
        private void btnGeneral_Click(object sender, EventArgs e)
        {
            appClass.clsDesign.clsUIDesign.OpenFormInTap(new frmCompanyInfo(), pnlTools, pnlMiddle);
            //ShowPNL(pnlGeneral);
        }

        // Menustrip Sales Bill
        private void mnuSalesBill_Click(object sender, EventArgs e)
        {
        }

        // Slide Menu Sales Bill
        private void btnSalesBill_Click(object sender, EventArgs e)
        {
            // wait
           appClass.clsDesign.clsUIDesign.OpenFormInTap(new frmSalesPOS(), pnlTools, pnlMiddle);
            //vfrmBillsMaster.ShowDialog(); //ok

        }

        // Company Info
        private void mnsCompanyInfo_Click(object sender, EventArgs e)
        {
            appClass.clsDesign.clsUIDesign.OpenFormInTap(new frmCompanyInfo(), pnlTools, pnlMiddle);
        }


        // Branch Info 
        private void mnsBranchInfo_Click(object sender, EventArgs e)
        {
            appClass.clsDesign.clsUIDesign.OpenFormInTap(new frmBranch_Info(), pnlTools, pnlMiddle);
        }

        // Customers 
        private void mnuClinets_Click(object sender, EventArgs e)
        {
            appClass.clsDesign.clsUIDesign.OpenFormInTap(new frmCustomers(), pnlTools, pnlMiddle);
        }

        // Vendors 
        private void mnuVendors_Click(object sender, EventArgs e)
        {
            appClass.clsDesign.clsUIDesign.OpenFormInTap(new frmVendors(), pnlTools, pnlMiddle);
        }

        // Safe 
        private void mnuSafe_Click(object sender, EventArgs e)
        {
            appClass.clsDesign.clsUIDesign.OpenFormInTap(new frmSafe(), pnlTools, pnlMiddle);

        }

        // Items Card 
        private void mnsItems_Click(object sender, EventArgs e)
        {
            appClass.clsDesign.clsUIDesign.OpenFormInTap(new frmProductCard(), pnlTools, pnlMiddle);
        }

        // Copy Info 
        private void mnuCopyDetails_Click(object sender, EventArgs e)
        {
            frmCopyInfo frmCopyInfo = new frmCopyInfo();
            frmCopyInfo.ShowDialog();
        }


        #endregion

    }
}
