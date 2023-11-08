
namespace appFelxMax.appForms.OtherForms
{
    partial class frmMasterPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterPassword));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(12, 50);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(236, 23);
            this.txtPass.TabIndex = 1;
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(12, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.btnOK.Size = new System.Drawing.Size(236, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(12, 9);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(236, 30);
            this.pic.TabIndex = 1;
            // 
            // frmMasterPassword
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 132);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.txtPass);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMasterPassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "كلمة المرور";
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pic;
        private System.Windows.Forms.ErrorProvider epPassword;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.Button btnOK;
    }
}