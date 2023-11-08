
namespace appFelxMax.appForms.MenuForms.DuesForms
{
    partial class frmDues_Type
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
            this.pnlData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDues_High_Price = new System.Windows.Forms.NumericUpDown();
            this.chkDuesT_State = new System.Windows.Forms.CheckBox();
            this.lblBranch_State = new System.Windows.Forms.Label();
            this.txtDuesT_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuesT_Note = new System.Windows.Forms.TextBox();
            this.txtDuesT_ID = new System.Windows.Forms.TextBox();
            this.lblBranch_Notes = new System.Windows.Forms.Label();
            this.lblBranch_Address = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgvDuesT = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDues_High_Price)).BeginInit();
            this.pnlOperations.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuesT)).BeginInit();
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
            this.lblHead.Size = new System.Drawing.Size(671, 41);
            this.lblHead.TabIndex = 14;
            this.lblHead.Text = "أنواع المصروفات";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.SystemColors.Window;
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.txtDues_High_Price);
            this.pnlData.Controls.Add(this.chkDuesT_State);
            this.pnlData.Controls.Add(this.lblBranch_State);
            this.pnlData.Controls.Add(this.txtDuesT_Name);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.txtDuesT_Note);
            this.pnlData.Controls.Add(this.txtDuesT_ID);
            this.pnlData.Controls.Add(this.lblBranch_Notes);
            this.pnlData.Controls.Add(this.lblBranch_Address);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 41);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(671, 137);
            this.pnlData.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label2.Location = new System.Drawing.Point(594, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "القيمة العليا";
            // 
            // txtDues_High_Price
            // 
            this.txtDues_High_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDues_High_Price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDues_High_Price.DecimalPlaces = 2;
            this.txtDues_High_Price.Location = new System.Drawing.Point(393, 83);
            this.txtDues_High_Price.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtDues_High_Price.Name = "txtDues_High_Price";
            this.txtDues_High_Price.Size = new System.Drawing.Size(195, 36);
            this.txtDues_High_Price.TabIndex = 27;
            this.txtDues_High_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkDuesT_State
            // 
            this.chkDuesT_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDuesT_State.AutoSize = true;
            this.chkDuesT_State.Checked = true;
            this.chkDuesT_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDuesT_State.ForeColor = System.Drawing.Color.Green;
            this.chkDuesT_State.Location = new System.Drawing.Point(269, 50);
            this.chkDuesT_State.Name = "chkDuesT_State";
            this.chkDuesT_State.Size = new System.Drawing.Size(63, 33);
            this.chkDuesT_State.TabIndex = 26;
            this.chkDuesT_State.Text = "نشط";
            this.chkDuesT_State.UseVisualStyleBackColor = true;
            this.chkDuesT_State.CheckedChanged += new System.EventHandler(this.chkDuesT_State_CheckedChanged);
            // 
            // lblBranch_State
            // 
            this.lblBranch_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_State.AutoSize = true;
            this.lblBranch_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_State.Location = new System.Drawing.Point(336, 52);
            this.lblBranch_State.Name = "lblBranch_State";
            this.lblBranch_State.Size = new System.Drawing.Size(40, 29);
            this.lblBranch_State.TabIndex = 25;
            this.lblBranch_State.Text = "الحالة";
            // 
            // txtDuesT_Name
            // 
            this.txtDuesT_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuesT_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDuesT_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuesT_Name.Location = new System.Drawing.Point(393, 47);
            this.txtDuesT_Name.Name = "txtDuesT_Name";
            this.txtDuesT_Name.Size = new System.Drawing.Size(195, 29);
            this.txtDuesT_Name.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label1.Location = new System.Drawing.Point(594, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "اسم";
            // 
            // txtDuesT_Note
            // 
            this.txtDuesT_Note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuesT_Note.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDuesT_Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuesT_Note.Location = new System.Drawing.Point(12, 10);
            this.txtDuesT_Note.Multiline = true;
            this.txtDuesT_Note.Name = "txtDuesT_Note";
            this.txtDuesT_Note.Size = new System.Drawing.Size(320, 29);
            this.txtDuesT_Note.TabIndex = 22;
            // 
            // txtDuesT_ID
            // 
            this.txtDuesT_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuesT_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDuesT_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuesT_ID.Location = new System.Drawing.Point(393, 10);
            this.txtDuesT_ID.Name = "txtDuesT_ID";
            this.txtDuesT_ID.Size = new System.Drawing.Size(195, 29);
            this.txtDuesT_ID.TabIndex = 21;
            this.txtDuesT_ID.TextChanged += new System.EventHandler(this.txtDuesT_ID_TextChanged);
            // 
            // lblBranch_Notes
            // 
            this.lblBranch_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Notes.AutoSize = true;
            this.lblBranch_Notes.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Notes.Location = new System.Drawing.Point(336, 12);
            this.lblBranch_Notes.Name = "lblBranch_Notes";
            this.lblBranch_Notes.Size = new System.Drawing.Size(62, 29);
            this.lblBranch_Notes.TabIndex = 20;
            this.lblBranch_Notes.Text = "ملاحظات ";
            // 
            // lblBranch_Address
            // 
            this.lblBranch_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Address.AutoSize = true;
            this.lblBranch_Address.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Address.Location = new System.Drawing.Point(594, 10);
            this.lblBranch_Address.Name = "lblBranch_Address";
            this.lblBranch_Address.Size = new System.Drawing.Size(32, 29);
            this.lblBranch_Address.TabIndex = 19;
            this.lblBranch_Address.Text = "رقم";
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.SystemColors.Window;
            this.pnlOperations.Controls.Add(this.button1);
            this.pnlOperations.Controls.Add(this.btnSave);
            this.pnlOperations.Controls.Add(this.btnNew);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 178);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(671, 51);
            this.pnlOperations.TabIndex = 17;
            // 
            // pnlDGV
            // 
            this.pnlDGV.Controls.Add(this.dgvDuesT);
            this.pnlDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDGV.Location = new System.Drawing.Point(0, 229);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(671, 307);
            this.pnlDGV.TabIndex = 18;
            // 
            // dgvDuesT
            // 
            this.dgvDuesT.AllowUserToAddRows = false;
            this.dgvDuesT.AllowUserToDeleteRows = false;
            this.dgvDuesT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDuesT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDuesT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuesT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuesT.Location = new System.Drawing.Point(0, 0);
            this.dgvDuesT.Name = "dgvDuesT";
            this.dgvDuesT.ReadOnly = true;
            this.dgvDuesT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDuesT.Size = new System.Drawing.Size(671, 307);
            this.dgvDuesT.TabIndex = 19;
            this.dgvDuesT.Click += new System.EventHandler(this.dgvDuesT_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(175, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "مسح - Del";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnSave.Location = new System.Drawing.Point(283, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
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
            this.btnNew.Location = new System.Drawing.Point(391, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 42);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmDues_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 536);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDues_Type";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انواع المصروفات";
            this.Load += new System.EventHandler(this.frmDues_Type_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDues_Type_KeyDown);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDues_High_Price)).EndInit();
            this.pnlOperations.ResumeLayout(false);
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuesT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.CheckBox chkDuesT_State;
        private System.Windows.Forms.Label lblBranch_State;
        private System.Windows.Forms.TextBox txtDuesT_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuesT_Note;
        private System.Windows.Forms.TextBox txtDuesT_ID;
        private System.Windows.Forms.Label lblBranch_Notes;
        private System.Windows.Forms.Label lblBranch_Address;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.DataGridView dgvDuesT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtDues_High_Price;
    }
}