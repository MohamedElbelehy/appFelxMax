
namespace appFelxMax.appForms.MenuForms.Program_initialization
{
    partial class frmStore_Init
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
            this.pnlBranch = new System.Windows.Forms.Panel();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.lblBranch_Company = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_S_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_State = new System.Windows.Forms.CheckBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lblBranch_Notes = new System.Windows.Forms.Label();
            this.lblBranch_State = new System.Windows.Forms.Label();
            this.lblBranch_ID = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtStore_Branch_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBranch.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.lblHead.Size = new System.Drawing.Size(874, 41);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "إضافة مخزن";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBranch
            // 
            this.pnlBranch.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBranch.Controls.Add(this.txtStore_Branch_ID);
            this.pnlBranch.Controls.Add(this.label2);
            this.pnlBranch.Controls.Add(this.cmbBranch);
            this.pnlBranch.Controls.Add(this.lblBranch_Company);
            this.pnlBranch.Controls.Add(this.txtLocation);
            this.pnlBranch.Controls.Add(this.label1);
            this.pnlBranch.Controls.Add(this.txt_Name);
            this.pnlBranch.Controls.Add(this.label4);
            this.pnlBranch.Controls.Add(this.dtp_S_Date);
            this.pnlBranch.Controls.Add(this.label6);
            this.pnlBranch.Controls.Add(this.chk_State);
            this.pnlBranch.Controls.Add(this.txt_Notes);
            this.pnlBranch.Controls.Add(this.txt_ID);
            this.pnlBranch.Controls.Add(this.lblBranch_Notes);
            this.pnlBranch.Controls.Add(this.lblBranch_State);
            this.pnlBranch.Controls.Add(this.lblBranch_ID);
            this.pnlBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBranch.Location = new System.Drawing.Point(0, 41);
            this.pnlBranch.Name = "pnlBranch";
            this.pnlBranch.Size = new System.Drawing.Size(874, 178);
            this.pnlBranch.TabIndex = 1;
            // 
            // cmbBranch
            // 
            this.cmbBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBranch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(450, 128);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(320, 37);
            this.cmbBranch.TabIndex = 3;
            // 
            // lblBranch_Company
            // 
            this.lblBranch_Company.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Company.AutoSize = true;
            this.lblBranch_Company.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Company.Location = new System.Drawing.Point(779, 132);
            this.lblBranch_Company.Name = "lblBranch_Company";
            this.lblBranch_Company.Size = new System.Drawing.Size(64, 29);
            this.lblBranch_Company.TabIndex = 39;
            this.lblBranch_Company.Text = "تابع للفرع";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Location = new System.Drawing.Point(28, 10);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(320, 29);
            this.txtLocation.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label1.Location = new System.Drawing.Point(357, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "مكان المخزن";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Location = new System.Drawing.Point(450, 48);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(320, 29);
            this.txt_Name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label4.Location = new System.Drawing.Point(779, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "اسم";
            // 
            // dtp_S_Date
            // 
            this.dtp_S_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_S_Date.Location = new System.Drawing.Point(450, 86);
            this.dtp_S_Date.Name = "dtp_S_Date";
            this.dtp_S_Date.Size = new System.Drawing.Size(320, 36);
            this.dtp_S_Date.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "تاريخ الانشاء";
            // 
            // chk_State
            // 
            this.chk_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_State.AutoSize = true;
            this.chk_State.Checked = true;
            this.chk_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_State.ForeColor = System.Drawing.Color.Green;
            this.chk_State.Location = new System.Drawing.Point(285, 91);
            this.chk_State.Name = "chk_State";
            this.chk_State.Size = new System.Drawing.Size(63, 33);
            this.chk_State.TabIndex = 6;
            this.chk_State.Text = "نشط";
            this.chk_State.UseVisualStyleBackColor = true;
            this.chk_State.CheckedChanged += new System.EventHandler(this.chk_State_CheckedChanged);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Notes.Location = new System.Drawing.Point(28, 51);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(320, 29);
            this.txt_Notes.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Location = new System.Drawing.Point(450, 10);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(320, 29);
            this.txt_ID.TabIndex = 0;
            // 
            // lblBranch_Notes
            // 
            this.lblBranch_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Notes.AutoSize = true;
            this.lblBranch_Notes.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Notes.Location = new System.Drawing.Point(357, 51);
            this.lblBranch_Notes.Name = "lblBranch_Notes";
            this.lblBranch_Notes.Size = new System.Drawing.Size(62, 29);
            this.lblBranch_Notes.TabIndex = 6;
            this.lblBranch_Notes.Text = "ملاحظات ";
            // 
            // lblBranch_State
            // 
            this.lblBranch_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_State.AutoSize = true;
            this.lblBranch_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_State.Location = new System.Drawing.Point(357, 93);
            this.lblBranch_State.Name = "lblBranch_State";
            this.lblBranch_State.Size = new System.Drawing.Size(65, 29);
            this.lblBranch_State.TabIndex = 5;
            this.lblBranch_State.Text = "حالة الخزنة";
            // 
            // lblBranch_ID
            // 
            this.lblBranch_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_ID.AutoSize = true;
            this.lblBranch_ID.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_ID.Location = new System.Drawing.Point(779, 11);
            this.lblBranch_ID.Name = "lblBranch_ID";
            this.lblBranch_ID.Size = new System.Drawing.Size(32, 29);
            this.lblBranch_ID.TabIndex = 8;
            this.lblBranch_ID.Text = "رقم";
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.SystemColors.Window;
            this.pnlOperations.Controls.Add(this.btnDelete);
            this.pnlOperations.Controls.Add(this.btnSave);
            this.pnlOperations.Controls.Add(this.btnNew);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 219);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(874, 50);
            this.pnlOperations.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(277, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "مسح - Del";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(385, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ - F2";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(493, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 42);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlDGV
            // 
            this.pnlDGV.Controls.Add(this.dgv);
            this.pnlDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDGV.Location = new System.Drawing.Point(0, 269);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(874, 229);
            this.pnlDGV.TabIndex = 20;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv.Size = new System.Drawing.Size(874, 229);
            this.dgv.TabIndex = 0;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // txtStore_Branch_ID
            // 
            this.txtStore_Branch_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStore_Branch_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStore_Branch_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStore_Branch_ID.Location = new System.Drawing.Point(28, 130);
            this.txtStore_Branch_ID.Name = "txtStore_Branch_ID";
            this.txtStore_Branch_ID.ReadOnly = true;
            this.txtStore_Branch_ID.Size = new System.Drawing.Size(320, 29);
            this.txtStore_Branch_ID.TabIndex = 40;
            this.txtStore_Branch_ID.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label2.Location = new System.Drawing.Point(357, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "رقم مخزن الفرع";
            this.label2.Visible = false;
            // 
            // frmStore_Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 498);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.pnlBranch);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmStore_Init";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعريف المخازن";
            this.Load += new System.EventHandler(this.frmStore_Init_Load);
            this.pnlBranch.ResumeLayout(false);
            this.pnlBranch.PerformLayout();
            this.pnlOperations.ResumeLayout(false);
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlBranch;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_S_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_State;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lblBranch_Notes;
        private System.Windows.Forms.Label lblBranch_State;
        private System.Windows.Forms.Label lblBranch_ID;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label lblBranch_Company;
        private System.Windows.Forms.TextBox txtStore_Branch_ID;
        private System.Windows.Forms.Label label2;
    }
}