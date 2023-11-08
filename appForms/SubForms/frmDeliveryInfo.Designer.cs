
namespace appFelxMax.appForms.SubForms
{
    partial class frmDeliveryInfo
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
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.pnlValue = new System.Windows.Forms.Panel();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.lblValue = new System.Windows.Forms.Label();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbPilot = new System.Windows.Forms.ComboBox();
            this.pnlOperations.SuspendLayout();
            this.pnlValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.pnlAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOperations.Controls.Add(this.btnExit);
            this.pnlOperations.Controls.Add(this.btnSave);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 40);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(300, 40);
            this.pnlOperations.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(91, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "خروج - ESC";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(197, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ - F2";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
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
            this.lblHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHead.Size = new System.Drawing.Size(300, 40);
            this.lblHead.TabIndex = 12;
            this.lblHead.Text = "بيانات التوصيل";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlValue
            // 
            this.pnlValue.Controls.Add(this.numValue);
            this.pnlValue.Controls.Add(this.lblValue);
            this.pnlValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValue.Location = new System.Drawing.Point(0, 80);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Size = new System.Drawing.Size(300, 60);
            this.pnlValue.TabIndex = 14;
            // 
            // numValue
            // 
            this.numValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.numValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numValue.ForeColor = System.Drawing.Color.White;
            this.numValue.Location = new System.Drawing.Point(0, 34);
            this.numValue.Name = "numValue";
            this.numValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numValue.Size = new System.Drawing.Size(300, 26);
            this.numValue.TabIndex = 1;
            this.numValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.Gray;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(0, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(300, 30);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "قيمة التوصيل";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlAddress
            // 
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Controls.Add(this.lblAddress);
            this.pnlAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddress.Location = new System.Drawing.Point(0, 140);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(300, 84);
            this.pnlAddress.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Wheat;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAddress.Location = new System.Drawing.Point(0, 30);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 54);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Gray;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(0, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(300, 30);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "العنوان التفصيلي";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbPilot
            // 
            this.cmbPilot.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbPilot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbPilot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPilot.FormattingEnabled = true;
            this.cmbPilot.Location = new System.Drawing.Point(0, 230);
            this.cmbPilot.Name = "cmbPilot";
            this.cmbPilot.Size = new System.Drawing.Size(300, 30);
            this.cmbPilot.TabIndex = 16;
            // 
            // frmDeliveryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.cmbPilot);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.pnlValue);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeliveryInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بيانات التوصيل";
            this.pnlOperations.ResumeLayout(false);
            this.pnlValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbPilot;
    }
}