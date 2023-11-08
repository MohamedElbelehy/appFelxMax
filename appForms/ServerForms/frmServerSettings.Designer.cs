
namespace appFelxMax.appForms.ServerForms
{
    partial class frmServerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerSettings));
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.lblDBName = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbType = new System.Windows.Forms.RadioButton();
            this.btnSaveConn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ForeColor = System.Drawing.Color.Black;
            this.lblServerName.Location = new System.Drawing.Point(12, 96);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(68, 22);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "ServerName";
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerName.Location = new System.Drawing.Point(86, 96);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(276, 23);
            this.txtServerName.TabIndex = 1;
            // 
            // btnTestConn
            // 
            this.btnTestConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTestConn.FlatAppearance.BorderSize = 0;
            this.btnTestConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTestConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConn.ForeColor = System.Drawing.Color.White;
            this.btnTestConn.Location = new System.Drawing.Point(86, 273);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(276, 35);
            this.btnTestConn.TabIndex = 6;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = false;
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.ForeColor = System.Drawing.Color.Black;
            this.lblDBName.Location = new System.Drawing.Point(12, 132);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(52, 22);
            this.lblDBName.TabIndex = 0;
            this.lblDBName.Text = "DB Name";
            // 
            // txtDBName
            // 
            this.txtDBName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDBName.Location = new System.Drawing.Point(86, 132);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(276, 23);
            this.txtDBName.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(12, 168);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(61, 22);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(86, 168);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(276, 23);
            this.txtUserName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(12, 204);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 22);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(86, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // rbType
            // 
            this.rbType.AutoSize = true;
            this.rbType.BackColor = System.Drawing.Color.Transparent;
            this.rbType.ForeColor = System.Drawing.Color.Black;
            this.rbType.Location = new System.Drawing.Point(86, 240);
            this.rbType.Name = "rbType";
            this.rbType.Size = new System.Drawing.Size(107, 26);
            this.rbType.TabIndex = 5;
            this.rbType.TabStop = true;
            this.rbType.Text = "Connection Copy";
            this.rbType.UseVisualStyleBackColor = false;
            // 
            // btnSaveConn
            // 
            this.btnSaveConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSaveConn.FlatAppearance.BorderSize = 0;
            this.btnSaveConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSaveConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConn.ForeColor = System.Drawing.Color.White;
            this.btnSaveConn.Location = new System.Drawing.Point(86, 314);
            this.btnSaveConn.Name = "btnSaveConn";
            this.btnSaveConn.Size = new System.Drawing.Size(276, 35);
            this.btnSaveConn.TabIndex = 7;
            this.btnSaveConn.Text = "Save Connection";
            this.btnSaveConn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "اعدادات السيرفر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmServerSettings
            // 
            this.AcceptButton = this.btnTestConn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbType);
            this.Controls.Add(this.btnSaveConn);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.lblDBName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblServerName);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اعدادات السيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbType;
        private System.Windows.Forms.Button btnSaveConn;
        private System.Windows.Forms.Label label1;
    }
}