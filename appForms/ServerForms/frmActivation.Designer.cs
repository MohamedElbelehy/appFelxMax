
namespace appFelxMax.appForms.ServerForms
{
    partial class frmActivation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivation));
            this.txtActivationCode = new System.Windows.Forms.TextBox();
            this.lblCopySig = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.btnActviate = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblAct = new System.Windows.Forms.Label();
            this.txtMacAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtActivationCode
            // 
            this.txtActivationCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtActivationCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivationCode.Location = new System.Drawing.Point(56, 185);
            this.txtActivationCode.Name = "txtActivationCode";
            this.txtActivationCode.Size = new System.Drawing.Size(316, 23);
            this.txtActivationCode.TabIndex = 2;
            // 
            // lblCopySig
            // 
            this.lblCopySig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCopySig.ForeColor = System.Drawing.Color.Black;
            this.lblCopySig.Location = new System.Drawing.Point(12, 88);
            this.lblCopySig.Name = "lblCopySig";
            this.lblCopySig.Size = new System.Drawing.Size(360, 36);
            this.lblCopySig.TabIndex = 0;
            this.lblCopySig.Text = "بصمة النسخة";
            this.lblCopySig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerial.Location = new System.Drawing.Point(56, 156);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(316, 23);
            this.txtSerial.TabIndex = 1;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOwnerName.Location = new System.Drawing.Point(56, 127);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(316, 23);
            this.txtOwnerName.TabIndex = 1;
            // 
            // btnActviate
            // 
            this.btnActviate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnActviate.FlatAppearance.BorderSize = 0;
            this.btnActviate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnActviate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActviate.ForeColor = System.Drawing.Color.White;
            this.btnActviate.Image = ((System.Drawing.Image)(resources.GetObject("btnActviate.Image")));
            this.btnActviate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActviate.Location = new System.Drawing.Point(56, 214);
            this.btnActviate.Name = "btnActviate";
            this.btnActviate.Padding = new System.Windows.Forms.Padding(105, 0, 110, 0);
            this.btnActviate.Size = new System.Drawing.Size(316, 35);
            this.btnActviate.TabIndex = 3;
            this.btnActviate.Text = "تفعيل";
            this.btnActviate.UseVisualStyleBackColor = false;
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(384, 40);
            this.lblHead.TabIndex = 8;
            this.lblHead.Text = "تفعيل البرنامج";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOwner
            // 
            this.lblOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOwner.ForeColor = System.Drawing.Color.Black;
            this.lblOwner.Image = ((System.Drawing.Image)(resources.GetObject("lblOwner.Image")));
            this.lblOwner.Location = new System.Drawing.Point(27, 127);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(23, 23);
            this.lblOwner.TabIndex = 0;
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerial
            // 
            this.lblSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSerial.ForeColor = System.Drawing.Color.Black;
            this.lblSerial.Image = ((System.Drawing.Image)(resources.GetObject("lblSerial.Image")));
            this.lblSerial.Location = new System.Drawing.Point(27, 156);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(23, 23);
            this.lblSerial.TabIndex = 0;
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAct
            // 
            this.lblAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAct.ForeColor = System.Drawing.Color.Black;
            this.lblAct.Image = ((System.Drawing.Image)(resources.GetObject("lblAct.Image")));
            this.lblAct.Location = new System.Drawing.Point(27, 185);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(23, 23);
            this.lblAct.TabIndex = 0;
            this.lblAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMacAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMacAddress.Location = new System.Drawing.Point(56, 62);
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(316, 23);
            this.txtMacAddress.TabIndex = 1;
            // 
            // frmActivation
            // 
            this.AcceptButton = this.btnActviate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtMacAddress);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnActviate);
            this.Controls.Add(this.lblAct);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblCopySig);
            this.Controls.Add(this.txtActivationCode);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActivation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تفعيل البرنامج";
            this.Load += new System.EventHandler(this.frmActivation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActivationCode;
        private System.Windows.Forms.Label lblCopySig;
        private System.Windows.Forms.Button btnActviate;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.TextBox txtMacAddress;
    }
}