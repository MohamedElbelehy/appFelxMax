
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
            this.lblSignature = new System.Windows.Forms.Label();
            this.cmbMacAddress = new System.Windows.Forms.ComboBox();
            this.floMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblOff = new System.Windows.Forms.Label();
            this.txtOff = new System.Windows.Forms.TextBox();
            this.lblOn = new System.Windows.Forms.Label();
            this.txtOn = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.floMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSignature
            // 
            this.lblSignature.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSignature.Location = new System.Drawing.Point(0, 40);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(384, 30);
            this.lblSignature.TabIndex = 9;
            this.lblSignature.Text = "بصمة النسخة";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMacAddress
            // 
            this.cmbMacAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMacAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbMacAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMacAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMacAddress.FormattingEnabled = true;
            this.cmbMacAddress.Location = new System.Drawing.Point(0, 70);
            this.cmbMacAddress.Name = "cmbMacAddress";
            this.cmbMacAddress.Size = new System.Drawing.Size(384, 30);
            this.cmbMacAddress.TabIndex = 10;
            // 
            // floMain
            // 
            this.floMain.Controls.Add(this.lblOwner);
            this.floMain.Controls.Add(this.txtOwner);
            this.floMain.Controls.Add(this.lblOff);
            this.floMain.Controls.Add(this.txtOff);
            this.floMain.Controls.Add(this.lblOn);
            this.floMain.Controls.Add(this.txtOn);
            this.floMain.Controls.Add(this.btnActivate);
            this.floMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floMain.Location = new System.Drawing.Point(0, 100);
            this.floMain.Name = "floMain";
            this.floMain.Size = new System.Drawing.Size(384, 151);
            this.floMain.TabIndex = 11;
            // 
            // lblOwner
            // 
            this.lblOwner.Image = global::appFelxMax.Properties.Resources.OwnerColor;
            this.lblOwner.Location = new System.Drawing.Point(3, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(25, 22);
            this.lblOwner.TabIndex = 0;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(34, 3);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(338, 30);
            this.txtOwner.TabIndex = 1;
            this.txtOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOff
            // 
            this.lblOff.Image = global::appFelxMax.Properties.Resources.OffColor;
            this.lblOff.Location = new System.Drawing.Point(3, 36);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(25, 22);
            this.lblOff.TabIndex = 2;
            // 
            // txtOff
            // 
            this.txtOff.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtOff.Location = new System.Drawing.Point(34, 39);
            this.txtOff.Name = "txtOff";
            this.txtOff.ReadOnly = true;
            this.txtOff.Size = new System.Drawing.Size(338, 30);
            this.txtOff.TabIndex = 3;
            this.txtOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOn
            // 
            this.lblOn.Image = global::appFelxMax.Properties.Resources.OnColor;
            this.lblOn.Location = new System.Drawing.Point(3, 72);
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(25, 22);
            this.lblOn.TabIndex = 4;
            // 
            // txtOn
            // 
            this.txtOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtOn.Location = new System.Drawing.Point(34, 75);
            this.txtOn.Name = "txtOn";
            this.txtOn.Size = new System.Drawing.Size(338, 30);
            this.txtOn.TabIndex = 5;
            this.txtOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnActivate.Image = global::appFelxMax.Properties.Resources.DoneColored;
            this.btnActivate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivate.Location = new System.Drawing.Point(3, 111);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Padding = new System.Windows.Forms.Padding(130, 0, 150, 0);
            this.btnActivate.Size = new System.Drawing.Size(369, 35);
            this.btnActivate.TabIndex = 6;
            this.btnActivate.Text = "تفعيل";
            this.btnActivate.UseVisualStyleBackColor = false;
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHead.Image = global::appFelxMax.Properties.Resources.Key;
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.lblHead.Size = new System.Drawing.Size(384, 40);
            this.lblHead.TabIndex = 8;
            this.lblHead.Text = "تفعيل البرنامج";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmActivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 251);
            this.Controls.Add(this.floMain);
            this.Controls.Add(this.cmbMacAddress);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActivation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفعيل البرنامج";
            this.Load += new System.EventHandler(this.frmActivation_Load);
            this.floMain.ResumeLayout(false);
            this.floMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.ComboBox cmbMacAddress;
        private System.Windows.Forms.FlowLayoutPanel floMain;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.TextBox txtOff;
        private System.Windows.Forms.Label lblOn;
        private System.Windows.Forms.TextBox txtOn;
        private System.Windows.Forms.Button btnActivate;
    }
}