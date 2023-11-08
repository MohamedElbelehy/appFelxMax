
namespace appFelxMax.appForms.MenuForms.Program_initialization
{
    partial class frmUnits
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
            this.chk_State = new System.Windows.Forms.CheckBox();
            this.lblBranch_State = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lblBranch_Notes = new System.Windows.Forms.Label();
            this.lblBranch_Address = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pnlData.SuspendLayout();
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
            this.lblHead.Size = new System.Drawing.Size(596, 41);
            this.lblHead.TabIndex = 15;
            this.lblHead.Text = "الوحدات";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.SystemColors.Window;
            this.pnlData.Controls.Add(this.cmbType);
            this.pnlData.Controls.Add(this.chk_State);
            this.pnlData.Controls.Add(this.lblBranch_State);
            this.pnlData.Controls.Add(this.txt_Name);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.txt_ID);
            this.pnlData.Controls.Add(this.lblBranch_Notes);
            this.pnlData.Controls.Add(this.lblBranch_Address);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 41);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(596, 103);
            this.pnlData.TabIndex = 16;
            // 
            // chk_State
            // 
            this.chk_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_State.AutoSize = true;
            this.chk_State.Checked = true;
            this.chk_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_State.ForeColor = System.Drawing.Color.Green;
            this.chk_State.Location = new System.Drawing.Point(232, 50);
            this.chk_State.Name = "chk_State";
            this.chk_State.Size = new System.Drawing.Size(63, 33);
            this.chk_State.TabIndex = 26;
            this.chk_State.Text = "نشط";
            this.chk_State.UseVisualStyleBackColor = true;
            this.chk_State.CheckedChanged += new System.EventHandler(this.chk_State_CheckedChanged);
            // 
            // lblBranch_State
            // 
            this.lblBranch_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_State.AutoSize = true;
            this.lblBranch_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_State.Location = new System.Drawing.Point(299, 52);
            this.lblBranch_State.Name = "lblBranch_State";
            this.lblBranch_State.Size = new System.Drawing.Size(40, 29);
            this.lblBranch_State.TabIndex = 25;
            this.lblBranch_State.Text = "الحالة";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Location = new System.Drawing.Point(50, 10);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(245, 29);
            this.txt_Name.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label1.Location = new System.Drawing.Point(299, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "اسم";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Location = new System.Drawing.Point(351, 10);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(195, 29);
            this.txt_ID.TabIndex = 21;
            // 
            // lblBranch_Notes
            // 
            this.lblBranch_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Notes.AutoSize = true;
            this.lblBranch_Notes.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Notes.Location = new System.Drawing.Point(552, 52);
            this.lblBranch_Notes.Name = "lblBranch_Notes";
            this.lblBranch_Notes.Size = new System.Drawing.Size(32, 29);
            this.lblBranch_Notes.TabIndex = 20;
            this.lblBranch_Notes.Text = "نوع";
            // 
            // lblBranch_Address
            // 
            this.lblBranch_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Address.AutoSize = true;
            this.lblBranch_Address.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Address.Location = new System.Drawing.Point(552, 10);
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
            this.pnlOperations.Location = new System.Drawing.Point(0, 144);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(596, 51);
            this.pnlOperations.TabIndex = 18;
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
            this.button1.Location = new System.Drawing.Point(138, 4);
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
            this.btnSave.Location = new System.Drawing.Point(246, 4);
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
            this.btnNew.Location = new System.Drawing.Point(354, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 42);
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
            this.pnlDGV.Location = new System.Drawing.Point(0, 195);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(596, 271);
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
            this.dgv.Size = new System.Drawing.Size(596, 271);
            this.dgv.TabIndex = 19;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "كبري",
            "صغرى"});
            this.cmbType.Location = new System.Drawing.Point(351, 49);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(195, 37);
            this.cmbType.TabIndex = 27;
            // 
            // frmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 466);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmUnits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تعريف الوحدات";
            this.Load += new System.EventHandler(this.frmUnits_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUnits_KeyDown);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlOperations.ResumeLayout(false);
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.CheckBox chk_State;
        private System.Windows.Forms.Label lblBranch_State;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lblBranch_Notes;
        private System.Windows.Forms.Label lblBranch_Address;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbType;
    }
}