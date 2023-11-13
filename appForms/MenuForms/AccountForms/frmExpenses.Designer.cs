
namespace appFelxMax.appForms.MenuForms.AccountForms
{
    partial class frmExpenses
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
            this.lblHead = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbPilot = new System.Windows.Forms.ComboBox();
            this.pnlOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHead.Image = global::appFelxMax.Properties.Resources.DueAdd;
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHead.Size = new System.Drawing.Size(304, 40);
            this.lblHead.TabIndex = 13;
            this.lblHead.Text = "مصروف جديد";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.Color.LightGray;
            this.pnlOperations.Controls.Add(this.btnExit);
            this.pnlOperations.Controls.Add(this.btnSave);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 40);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(304, 40);
            this.pnlOperations.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(91, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "خروج - ESC";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::appFelxMax.Properties.Resources.DoneColored;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(197, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ - F2";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.Gray;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(0, 80);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(304, 30);
            this.lblValue.TabIndex = 15;
            this.lblValue.Text = "قيمة المصروف";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numValue
            // 
            this.numValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.numValue.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.numValue.Location = new System.Drawing.Point(0, 110);
            this.numValue.Name = "numValue";
            this.numValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numValue.Size = new System.Drawing.Size(304, 30);
            this.numValue.TabIndex = 16;
            this.numValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Gray;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(0, 140);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(304, 30);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "البيان";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Wheat;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescription.Location = new System.Drawing.Point(0, 170);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 55);
            this.txtDescription.TabIndex = 18;
            // 
            // cmbPilot
            // 
            this.cmbPilot.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbPilot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbPilot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPilot.FormattingEnabled = true;
            this.cmbPilot.Location = new System.Drawing.Point(0, 231);
            this.cmbPilot.Name = "cmbPilot";
            this.cmbPilot.Size = new System.Drawing.Size(304, 30);
            this.cmbPilot.TabIndex = 19;
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.cmbPilot);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.numValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExpenses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "المصروفات";
            this.pnlOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbPilot;
    }
}