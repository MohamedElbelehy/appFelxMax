
namespace appFelxMax.appForms.MenuForms.Program_initialization
{
    partial class frmStoreInfo
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
            this.btnESC = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.lblStore_ID = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.dtpStore_S_Date = new System.Windows.Forms.DateTimePicker();
            this.lblStore_Name = new System.Windows.Forms.Label();
            this.lblStartedDate = new System.Windows.Forms.Label();
            this.chkStoreState = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStore_State = new System.Windows.Forms.Label();
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.pnlOperations.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHead.Image = global::appFelxMax.Properties.Resources.StoreColor;
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHead.Size = new System.Drawing.Size(700, 40);
            this.lblHead.TabIndex = 18;
            this.lblHead.Text = "بيانات المخازن";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.Color.LightGray;
            this.pnlOperations.Controls.Add(this.btnESC);
            this.pnlOperations.Controls.Add(this.btnSave);
            this.pnlOperations.Controls.Add(this.btnNew);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 40);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(700, 40);
            this.pnlOperations.TabIndex = 26;
            // 
            // btnESC
            // 
            this.btnESC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnESC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnESC.FlatAppearance.BorderSize = 0;
            this.btnESC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESC.ForeColor = System.Drawing.Color.Black;
            this.btnESC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnESC.Location = new System.Drawing.Point(426, 3);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(90, 30);
            this.btnESC.TabIndex = 14;
            this.btnESC.Text = "خروج - ESC";
            this.btnESC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnESC.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::appFelxMax.Properties.Resources.DoneColored;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSave.Location = new System.Drawing.Point(522, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ - F2";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = global::appFelxMax.Properties.Resources.AddColor;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(608, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.cmbBranch);
            this.pnlData.Controls.Add(this.pnl2);
            this.pnlData.Controls.Add(this.txtStoreID);
            this.pnlData.Controls.Add(this.lblStore_ID);
            this.pnlData.Controls.Add(this.pnl1);
            this.pnlData.Controls.Add(this.txtStoreName);
            this.pnlData.Controls.Add(this.dtpStore_S_Date);
            this.pnlData.Controls.Add(this.lblStore_Name);
            this.pnlData.Controls.Add(this.lblStartedDate);
            this.pnlData.Controls.Add(this.chkStoreState);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.lblStore_State);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 80);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(700, 100);
            this.pnlData.TabIndex = 27;
            // 
            // cmbBranch
            // 
            this.cmbBranch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(12, 36);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(248, 30);
            this.cmbBranch.TabIndex = 28;
            // 
            // pnl2
            // 
            this.pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl2.BackColor = System.Drawing.Color.Silver;
            this.pnl2.Location = new System.Drawing.Point(668, 6);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(20, 88);
            this.pnl2.TabIndex = 27;
            // 
            // txtStoreID
            // 
            this.txtStoreID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoreID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStoreID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStoreID.Location = new System.Drawing.Point(356, 5);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.ReadOnly = true;
            this.txtStoreID.Size = new System.Drawing.Size(250, 23);
            this.txtStoreID.TabIndex = 12;
            // 
            // lblStore_ID
            // 
            this.lblStore_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStore_ID.AutoSize = true;
            this.lblStore_ID.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblStore_ID.Location = new System.Drawing.Point(609, 4);
            this.lblStore_ID.Name = "lblStore_ID";
            this.lblStore_ID.Size = new System.Drawing.Size(57, 22);
            this.lblStore_ID.TabIndex = 0;
            this.lblStore_ID.Text = "رقم المخزن";
            // 
            // pnl1
            // 
            this.pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl1.BackColor = System.Drawing.Color.Silver;
            this.pnl1.Location = new System.Drawing.Point(329, 5);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(20, 88);
            this.pnl1.TabIndex = 24;
            // 
            // txtStoreName
            // 
            this.txtStoreName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoreName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStoreName.Location = new System.Drawing.Point(356, 34);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(250, 23);
            this.txtStoreName.TabIndex = 13;
            // 
            // dtpStore_S_Date
            // 
            this.dtpStore_S_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStore_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStore_S_Date.Location = new System.Drawing.Point(356, 63);
            this.dtpStore_S_Date.Name = "dtpStore_S_Date";
            this.dtpStore_S_Date.Size = new System.Drawing.Size(250, 30);
            this.dtpStore_S_Date.TabIndex = 23;
            // 
            // lblStore_Name
            // 
            this.lblStore_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStore_Name.AutoSize = true;
            this.lblStore_Name.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblStore_Name.Location = new System.Drawing.Point(609, 35);
            this.lblStore_Name.Name = "lblStore_Name";
            this.lblStore_Name.Size = new System.Drawing.Size(61, 22);
            this.lblStore_Name.TabIndex = 1;
            this.lblStore_Name.Text = "اسم المخزن";
            // 
            // lblStartedDate
            // 
            this.lblStartedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartedDate.AutoSize = true;
            this.lblStartedDate.Location = new System.Drawing.Point(608, 68);
            this.lblStartedDate.Name = "lblStartedDate";
            this.lblStartedDate.Size = new System.Drawing.Size(52, 22);
            this.lblStartedDate.TabIndex = 22;
            this.lblStartedDate.Text = "تاريخ البدء";
            // 
            // chkStoreState
            // 
            this.chkStoreState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStoreState.AutoSize = true;
            this.chkStoreState.Checked = true;
            this.chkStoreState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStoreState.ForeColor = System.Drawing.Color.Green;
            this.chkStoreState.Location = new System.Drawing.Point(209, 4);
            this.chkStoreState.Name = "chkStoreState";
            this.chkStoreState.Size = new System.Drawing.Size(51, 26);
            this.chkStoreState.TabIndex = 20;
            this.chkStoreState.Text = "نشط";
            this.chkStoreState.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.label1.Location = new System.Drawing.Point(266, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "مرنبط بــــ";
            // 
            // lblStore_State
            // 
            this.lblStore_State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStore_State.AutoSize = true;
            this.lblStore_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblStore_State.Location = new System.Drawing.Point(266, 6);
            this.lblStore_State.Name = "lblStore_State";
            this.lblStore_State.Size = new System.Drawing.Size(57, 22);
            this.lblStore_State.TabIndex = 5;
            this.lblStore_State.Text = "حالة المخزن";
            // 
            // dgvStores
            // 
            this.dgvStores.AllowUserToAddRows = false;
            this.dgvStores.AllowUserToDeleteRows = false;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStores.Location = new System.Drawing.Point(0, 180);
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.ReadOnly = true;
            this.dgvStores.Size = new System.Drawing.Size(700, 320);
            this.dgvStores.TabIndex = 28;
            // 
            // frmStoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.dgvStores);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmStoreInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات المخازن";
            this.Load += new System.EventHandler(this.frmStore_Init_Load);
            this.pnlOperations.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Label lblStore_ID;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.DateTimePicker dtpStore_S_Date;
        private System.Windows.Forms.Label lblStore_Name;
        private System.Windows.Forms.Label lblStartedDate;
        private System.Windows.Forms.CheckBox chkStoreState;
        private System.Windows.Forms.Label lblStore_State;
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label1;
    }
}