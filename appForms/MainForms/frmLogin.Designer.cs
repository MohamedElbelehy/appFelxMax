
namespace appFelxMax.appForms.MainForms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbStores = new System.Windows.Forms.ComboBox();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.lblIPV4 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsServer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAtivation = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSYNC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRefSYNC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.iPassword = new System.Windows.Forms.Label();
            this.iStores = new System.Windows.Forms.Label();
            this.iUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlHead.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUser
            // 
            this.cmbUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(59, 320);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbUser.Size = new System.Drawing.Size(267, 26);
            this.cmbUser.TabIndex = 1;
            // 
            // lblConnection
            // 
            this.lblConnection.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConnection.Location = new System.Drawing.Point(59, 417);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(267, 30);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "حالة الاتصال";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Controls.Add(this.lblTitle);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(400, 30);
            this.pnlHead.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ContextMenuStrip = this.cmsMenu;
            this.lblTitle.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FelxMax";
            // 
            // cmsMenu
            // 
            this.cmsMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmsMenu.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsServer,
            this.cmsAtivation,
            this.cmsSYNC,
            this.cmsExit});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsMenu.Size = new System.Drawing.Size(152, 108);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(59, 352);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(267, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // cmbStores
            // 
            this.cmbStores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Location = new System.Drawing.Point(59, 288);
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStores.Size = new System.Drawing.Size(267, 26);
            this.cmbStores.TabIndex = 0;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSide.Controls.Add(this.lblIPV4);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 30);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(20, 520);
            this.pnlSide.TabIndex = 6;
            this.pnlSide.DoubleClick += new System.EventHandler(this.pnlSide_DoubleClick);
            // 
            // lblIPV4
            // 
            this.lblIPV4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIPV4.Location = new System.Drawing.Point(0, 0);
            this.lblIPV4.Name = "lblIPV4";
            this.lblIPV4.Size = new System.Drawing.Size(20, 30);
            this.lblIPV4.TabIndex = 0;
            this.lblIPV4.Text = "IP";
            this.lblIPV4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::appFelxMax.Properties.Resources.Icon;
            this.picLogo.Location = new System.Drawing.Point(123, 145);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::appFelxMax.Properties.Resources.CloseColor;
            this.btnClose.Location = new System.Drawing.Point(374, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmsServer
            // 
            this.cmsServer.Image = global::appFelxMax.Properties.Resources.ServerColor;
            this.cmsServer.Name = "cmsServer";
            this.cmsServer.Size = new System.Drawing.Size(151, 26);
            this.cmsServer.Text = "اعدادات السيرفر";
            this.cmsServer.Click += new System.EventHandler(this.cmsServer_Click);
            // 
            // cmsAtivation
            // 
            this.cmsAtivation.Image = global::appFelxMax.Properties.Resources.Key;
            this.cmsAtivation.Name = "cmsAtivation";
            this.cmsAtivation.Size = new System.Drawing.Size(151, 26);
            this.cmsAtivation.Text = "تفعيل البرنامج";
            this.cmsAtivation.Click += new System.EventHandler(this.cmsAtivation_Click);
            // 
            // cmsSYNC
            // 
            this.cmsSYNC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsRefSYNC});
            this.cmsSYNC.Image = global::appFelxMax.Properties.Resources.SynchronizeColor;
            this.cmsSYNC.Name = "cmsSYNC";
            this.cmsSYNC.Size = new System.Drawing.Size(151, 26);
            this.cmsSYNC.Text = "التزامن";
            // 
            // cmsRefSYNC
            // 
            this.cmsRefSYNC.Image = ((System.Drawing.Image)(resources.GetObject("cmsRefSYNC.Image")));
            this.cmsRefSYNC.Name = "cmsRefSYNC";
            this.cmsRefSYNC.Size = new System.Drawing.Size(138, 26);
            this.cmsRefSYNC.Text = "تزامن البيانات";
            // 
            // cmsExit
            // 
            this.cmsExit.Image = global::appFelxMax.Properties.Resources.LogoutColor;
            this.cmsExit.Name = "cmsExit";
            this.cmsExit.Size = new System.Drawing.Size(151, 26);
            this.cmsExit.Text = "خروج";
            // 
            // iPassword
            // 
            this.iPassword.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iPassword.Image = global::appFelxMax.Properties.Resources.PasswordW;
            this.iPassword.Location = new System.Drawing.Point(332, 352);
            this.iPassword.Name = "iPassword";
            this.iPassword.Size = new System.Drawing.Size(30, 26);
            this.iPassword.TabIndex = 2;
            // 
            // iStores
            // 
            this.iStores.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iStores.Image = global::appFelxMax.Properties.Resources.StoreW;
            this.iStores.Location = new System.Drawing.Point(332, 288);
            this.iStores.Name = "iStores";
            this.iStores.Size = new System.Drawing.Size(30, 26);
            this.iStores.TabIndex = 2;
            // 
            // iUser
            // 
            this.iUser.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iUser.Image = global::appFelxMax.Properties.Resources.UserNameW;
            this.iUser.Location = new System.Drawing.Point(332, 320);
            this.iUser.Name = "iUser";
            this.iUser.Size = new System.Drawing.Size(30, 26);
            this.iUser.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Image = global::appFelxMax.Properties.Resources.DoneColored;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(59, 384);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.btnLogin.Size = new System.Drawing.Size(267, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "تسجيل دخول";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.iPassword);
            this.Controls.Add(this.iStores);
            this.Controls.Add(this.iUser);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbStores);
            this.Controls.Add(this.cmbUser);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlHead.ResumeLayout(false);
            this.cmsMenu.ResumeLayout(false);
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label iUser;
        private System.Windows.Forms.Label iPassword;
        private System.Windows.Forms.Label iStores;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsServer;
        private System.Windows.Forms.ToolStripMenuItem cmsAtivation;
        private System.Windows.Forms.ToolStripMenuItem cmsExit;
        private System.Windows.Forms.ToolStripMenuItem cmsSYNC;
        private System.Windows.Forms.ToolStripMenuItem cmsRefSYNC;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label lblIPV4;
    }
}