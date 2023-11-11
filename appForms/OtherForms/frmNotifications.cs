using appFelxMax.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace appFelxMax.appForms.OtherForms
{
    public partial class frmNotifications : Form
    {
        public frmNotifications()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            eWait,
            eStart,
            eClose
        }

        public enum enmType
        {
            vSuccess,
            vWarning,
            vError,
            vInfo
        }
        private frmNotifications.enmAction vAction;

        private int x, y;


        private void timer_Tick(object sender, EventArgs e)
        {
            switch (this.vAction)
            {
                case enmAction.eWait:
                    timer.Interval = 3000;
                    vAction = enmAction.eClose;
                    break;
                case frmNotifications.enmAction.eStart:
                    this.timer.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            vAction = frmNotifications.enmAction.eWait;
                        }
                    }
                    break;
                case enmAction.eClose:
                    timer.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void picColse_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            vAction = enmAction.eClose;
        }

        public void fnShowAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmNotifications frm = (frmNotifications)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.vSuccess:
                    this.picIcon.Image = Resources.SuccessW;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.vError:
                    this.picIcon.Image = Resources.ErrorW;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.vInfo:
                    this.picIcon.Image = Resources.InfoW;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.vWarning:
                    this.picIcon.Image = Resources.WarrningW;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lblMsg.Text = msg;

            this.Show();
            this.vAction = enmAction.eStart;
            this.timer.Interval = 1;
            this.timer.Start();
        }

    }
}
