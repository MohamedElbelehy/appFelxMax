using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace appFelxMax.appForms.MainForms
{
    public partial class TapPage : UserControl
    {
        //var
        private string text;
        public Panel panelDir;
        private bool check;
        public Form formWorping;
        public Panel panelCOntainer;
        public TapPage()
        {
            InitializeComponent();
            lbl_Title.Text = text;
            panelDir = this.Parent as Panel;
        }
        public void Close()
        {
            int Form_index = panelCOntainer.Controls.IndexOf(formWorping.Parent);
            int Button_Index = this.Parent.Controls.IndexOf(this);


            if (Form_index < 0)
                panelCOntainer.Controls[Form_index - 1].BringToFront();
            if (Button_Index > 0)
            {
                ((TapPage)this.Parent.Controls[Button_Index - 1]).lbl_Title_Click(null, null);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                if (this.Parent.Controls.Count > 1)
                {

                    ((TapPage)this.Parent.Controls[Button_Index + 1]).lbl_Title_Click(null, null);
                }
            }

            panelCOntainer.Controls.Remove(formWorping.Parent);
            formWorping.Close();
        }

       public string Text { get => text; set { text = value; lbl_Title.Text = value; } }


        public bool Check
        {
            get => check; set
            {
                check = value;
                if (value == true)
                {
                    this.pnl_Check.BackColor = ColorTranslator.FromHtml("52, 152, 219");
                }
                else
                {
                    this.pnl_Check.BackColor = Color.White;
                }

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
           

            Close();
        }

        public void lbl_Title_Click(object sender, EventArgs e)
        {
            formWorping.Parent.BringToFront();
            this.Check = true;
            foreach (var item in this.Parent.Controls.OfType<TapPage>())
            {
                if (item.Name != this.Name)
                {
                    item.Check = false;
                }
            }
        }
    }
}
