
namespace appFelxMax.appForms.MenuForms.EmpForms
{
    partial class frmAttendanceDeparture
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
            this.cmbOperate = new System.Windows.Forms.ComboBox();
            this.cmbEmpName = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDelayPeriod = new System.Windows.Forms.Label();
            this.pnlOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHead.Image = global::appFelxMax.Properties.Resources.AttendanceColor;
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHead.Size = new System.Drawing.Size(304, 40);
            this.lblHead.TabIndex = 13;
            this.lblHead.Text = "الحضور والانصراف";
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
            this.lblValue.Text = "العملية";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbOperate
            // 
            this.cmbOperate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbOperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbOperate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOperate.FormattingEnabled = true;
            this.cmbOperate.Location = new System.Drawing.Point(0, 110);
            this.cmbOperate.Name = "cmbOperate";
            this.cmbOperate.Size = new System.Drawing.Size(304, 37);
            this.cmbOperate.TabIndex = 16;
            // 
            // cmbEmpName
            // 
            this.cmbEmpName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEmpName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmpName.FormattingEnabled = true;
            this.cmbEmpName.Location = new System.Drawing.Point(0, 147);
            this.cmbEmpName.Name = "cmbEmpName";
            this.cmbEmpName.Size = new System.Drawing.Size(304, 37);
            this.cmbEmpName.TabIndex = 17;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Gray;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(0, 184);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(304, 30);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "البيانات";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblDateTime.Location = new System.Drawing.Point(0, 214);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(304, 30);
            this.lblDateTime.TabIndex = 19;
            this.lblDateTime.Text = "الوقت والتاريخ";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelayPeriod
            // 
            this.lblDelayPeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDelayPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblDelayPeriod.Location = new System.Drawing.Point(0, 244);
            this.lblDelayPeriod.Name = "lblDelayPeriod";
            this.lblDelayPeriod.Size = new System.Drawing.Size(304, 30);
            this.lblDelayPeriod.TabIndex = 20;
            this.lblDelayPeriod.Text = "مدة التأخير ";
            this.lblDelayPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAttendanceDeparture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.lblDelayPeriod);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbEmpName);
            this.Controls.Add(this.cmbOperate);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttendanceDeparture";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "الحضور والانصراف ";
            this.pnlOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ComboBox cmbOperate;
        private System.Windows.Forms.ComboBox cmbEmpName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDelayPeriod;
    }
}