
namespace appFelxMax.appForms.MainForms
{
    partial class TapPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.pnl_Check = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(30, 1);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(119, 28);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "label1";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // lbl_Close
            // 
            this.lbl_Close.BackColor = System.Drawing.Color.White;
            this.lbl_Close.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Close.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_Close.Image = global::appFelxMax.Properties.Resources.CloseColor;
            this.lbl_Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Close.Location = new System.Drawing.Point(1, 1);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(29, 28);
            this.lbl_Close.TabIndex = 1;
            this.lbl_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_Check
            // 
            this.pnl_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Check.BackColor = System.Drawing.Color.White;
            this.pnl_Check.Location = new System.Drawing.Point(0, 23);
            this.pnl_Check.Name = "pnl_Check";
            this.pnl_Check.Size = new System.Drawing.Size(150, 3);
            this.pnl_Check.TabIndex = 2;
            // 
            // TapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Check);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Close);
            this.Name = "TapPage";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(150, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Panel pnl_Check;
    }
}
