
namespace appFelxMax.appForms.MenuForms.AccountForms
{
    partial class frmTreasure_MainCash
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Balance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Z_Balance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_S_Balance = new System.Windows.Forms.NumericUpDown();
            this.dtp_S_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.chk_State = new System.Windows.Forms.CheckBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lblBranch_Company = new System.Windows.Forms.Label();
            this.lblBranch_Notes = new System.Windows.Forms.Label();
            this.lblBranch_State = new System.Windows.Forms.Label();
            this.lblBranch_ID = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnlBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Z_Balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_S_Balance)).BeginInit();
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
            this.lblHead.Size = new System.Drawing.Size(1138, 41);
            this.lblHead.TabIndex = 15;
            this.lblHead.Text = "الخزنة الرئيسية";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBranch
            // 
            this.pnlBranch.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBranch.Controls.Add(this.btnNew);
            this.pnlBranch.Controls.Add(this.btnDelete);
            this.pnlBranch.Controls.Add(this.btnSave);
            this.pnlBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBranch.Location = new System.Drawing.Point(0, 41);
            this.pnlBranch.Name = "pnlBranch";
            this.pnlBranch.Size = new System.Drawing.Size(1138, 52);
            this.pnlBranch.TabIndex = 16;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Location = new System.Drawing.Point(728, 104);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(320, 29);
            this.txt_Name.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label4.Location = new System.Drawing.Point(1057, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "اسم";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label3.Location = new System.Drawing.Point(622, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "الرصيد الحالي";
            // 
            // txt_Balance
            // 
            this.txt_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Balance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Balance.DecimalPlaces = 2;
            this.txt_Balance.Location = new System.Drawing.Point(293, 146);
            this.txt_Balance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(320, 30);
            this.txt_Balance.TabIndex = 33;
            this.txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label1.Location = new System.Drawing.Point(622, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "القيمة الصفرية";
            // 
            // txt_Z_Balance
            // 
            this.txt_Z_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Z_Balance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Z_Balance.DecimalPlaces = 2;
            this.txt_Z_Balance.Location = new System.Drawing.Point(293, 104);
            this.txt_Z_Balance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_Z_Balance.Name = "txt_Z_Balance";
            this.txt_Z_Balance.Size = new System.Drawing.Size(320, 30);
            this.txt_Z_Balance.TabIndex = 31;
            this.txt_Z_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label2.Location = new System.Drawing.Point(622, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "الرصيد الإفتتاحي";
            // 
            // txt_S_Balance
            // 
            this.txt_S_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_S_Balance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_S_Balance.DecimalPlaces = 2;
            this.txt_S_Balance.Location = new System.Drawing.Point(293, 65);
            this.txt_S_Balance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_S_Balance.Name = "txt_S_Balance";
            this.txt_S_Balance.Size = new System.Drawing.Size(320, 30);
            this.txt_S_Balance.TabIndex = 29;
            this.txt_S_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_S_Date
            // 
            this.dtp_S_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_S_Date.Location = new System.Drawing.Point(728, 142);
            this.dtp_S_Date.Name = "dtp_S_Date";
            this.dtp_S_Date.Size = new System.Drawing.Size(160, 30);
            this.dtp_S_Date.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(894, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "تاريخ الانشاء";
            // 
            // cmbBranch
            // 
            this.cmbBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBranch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(-129, 63);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(320, 30);
            this.cmbBranch.TabIndex = 21;
            // 
            // chk_State
            // 
            this.chk_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_State.AutoSize = true;
            this.chk_State.Checked = true;
            this.chk_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_State.ForeColor = System.Drawing.Color.Green;
            this.chk_State.Location = new System.Drawing.Point(997, 147);
            this.chk_State.Name = "chk_State";
            this.chk_State.Size = new System.Drawing.Size(51, 26);
            this.chk_State.TabIndex = 20;
            this.chk_State.Text = "نشط";
            this.chk_State.UseVisualStyleBackColor = true;
            this.chk_State.CheckedChanged += new System.EventHandler(this.chk_State_CheckedChanged);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Notes.Location = new System.Drawing.Point(-129, 107);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(320, 29);
            this.txt_Notes.TabIndex = 18;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Location = new System.Drawing.Point(728, 66);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(320, 23);
            this.txt_ID.TabIndex = 12;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // lblBranch_Company
            // 
            this.lblBranch_Company.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Company.AutoSize = true;
            this.lblBranch_Company.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Company.Location = new System.Drawing.Point(200, 67);
            this.lblBranch_Company.Name = "lblBranch_Company";
            this.lblBranch_Company.Size = new System.Drawing.Size(70, 22);
            this.lblBranch_Company.TabIndex = 7;
            this.lblBranch_Company.Text = "الفرع التابع لها";
            // 
            // lblBranch_Notes
            // 
            this.lblBranch_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Notes.AutoSize = true;
            this.lblBranch_Notes.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Notes.Location = new System.Drawing.Point(200, 107);
            this.lblBranch_Notes.Name = "lblBranch_Notes";
            this.lblBranch_Notes.Size = new System.Drawing.Size(50, 22);
            this.lblBranch_Notes.TabIndex = 6;
            this.lblBranch_Notes.Text = "ملاحظات ";
            // 
            // lblBranch_State
            // 
            this.lblBranch_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_State.AutoSize = true;
            this.lblBranch_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_State.Location = new System.Drawing.Point(1057, 149);
            this.lblBranch_State.Name = "lblBranch_State";
            this.lblBranch_State.Size = new System.Drawing.Size(52, 22);
            this.lblBranch_State.TabIndex = 5;
            this.lblBranch_State.Text = "حالة الخزنة";
            // 
            // lblBranch_ID
            // 
            this.lblBranch_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_ID.AutoSize = true;
            this.lblBranch_ID.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_ID.Location = new System.Drawing.Point(1057, 67);
            this.lblBranch_ID.Name = "lblBranch_ID";
            this.lblBranch_ID.Size = new System.Drawing.Size(26, 22);
            this.lblBranch_ID.TabIndex = 0;
            this.lblBranch_ID.Text = "رقم";
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.SystemColors.Window;
            this.pnlOperations.Controls.Add(this.txt_Name);
            this.pnlOperations.Controls.Add(this.label4);
            this.pnlOperations.Controls.Add(this.label3);
            this.pnlOperations.Controls.Add(this.txt_Balance);
            this.pnlOperations.Controls.Add(this.lblBranch_ID);
            this.pnlOperations.Controls.Add(this.label1);
            this.pnlOperations.Controls.Add(this.lblBranch_State);
            this.pnlOperations.Controls.Add(this.txt_Z_Balance);
            this.pnlOperations.Controls.Add(this.lblBranch_Notes);
            this.pnlOperations.Controls.Add(this.label2);
            this.pnlOperations.Controls.Add(this.lblBranch_Company);
            this.pnlOperations.Controls.Add(this.txt_S_Balance);
            this.pnlOperations.Controls.Add(this.txt_ID);
            this.pnlOperations.Controls.Add(this.dtp_S_Date);
            this.pnlOperations.Controls.Add(this.txt_Notes);
            this.pnlOperations.Controls.Add(this.label6);
            this.pnlOperations.Controls.Add(this.chk_State);
            this.pnlOperations.Controls.Add(this.cmbBranch);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 93);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(1138, 216);
            this.pnlOperations.TabIndex = 18;
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
            this.btnDelete.Location = new System.Drawing.Point(873, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 16;
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
            this.btnSave.Location = new System.Drawing.Point(960, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 15;
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
            this.btnNew.Location = new System.Drawing.Point(1046, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 40);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlDGV
            // 
            this.pnlDGV.Controls.Add(this.dgv);
            this.pnlDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDGV.Location = new System.Drawing.Point(0, 93);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(1138, 418);
            this.pnlDGV.TabIndex = 19;
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
            this.dgv.Size = new System.Drawing.Size(1138, 418);
            this.dgv.TabIndex = 19;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // frmTreasure_MainCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 511);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.pnlBranch);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmTreasure_MainCash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الخزنة الرئيسية";
            this.Load += new System.EventHandler(this.frmTreasure_MainCash_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTreasure_MainCash_KeyDown);
            this.pnlBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Z_Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_S_Balance)).EndInit();
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlBranch;
        private System.Windows.Forms.DateTimePicker dtp_S_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.CheckBox chk_State;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lblBranch_Company;
        private System.Windows.Forms.Label lblBranch_Notes;
        private System.Windows.Forms.Label lblBranch_State;
        private System.Windows.Forms.Label lblBranch_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_Z_Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_S_Balance;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
    }
}