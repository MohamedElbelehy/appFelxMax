using appFelxMax.appClass.clsDesign;
using appFelxMax.appForms.OtherForms;
using appFelxMax.appForms.SubForms;
using System;
using System.Windows.Forms;

namespace appFelxMax.appForms.MainForms
{
    public partial class frmSalesPOS : Form
    {
        public frmSalesPOS()
        {
            InitializeComponent();
        }

        public void fnAlert(string msg, frmNotifications.enmType type)
        {
            frmNotifications frm = new frmNotifications();
            frm.fnShowAlert(msg, type);
        }

        private void frmSalesPOS_Load(object sender, EventArgs e)
        {
            clsUIDesign.fnDGVConfig(dgvBill);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          clsUIDesign.fnPnlDataConfig(pPnlData: pnlQuiekItems, pIsToggle: true, pIsOpen: false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           this.fnAlert("تم الحفظ بنجاح", frmNotifications.enmType.vSuccess);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.fnAlert("هذه معلومه...", frmNotifications.enmType.vInfo);

        }

        private void btnDelayed_Click(object sender, EventArgs e)
        {
            this.fnAlert("تحذير مهم", frmNotifications.enmType.vWarning);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.fnAlert("خطأ اثناء التحميل", frmNotifications.enmType.vError);

        }

        private void chkDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelivery.Checked)
            {
                frmDeliveryInfo frmDeliveryInfo = new frmDeliveryInfo();
                frmDeliveryInfo.ShowDialog();
            }
        }

        private void chkInstallment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstallment.Checked)
            {
                frmInstallment frmInstallment = new frmInstallment();
                frmInstallment.ShowDialog();
            }
        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
