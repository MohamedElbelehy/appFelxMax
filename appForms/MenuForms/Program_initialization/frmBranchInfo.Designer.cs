
namespace appFelxMax.appForms.MenuForms
{
    partial class frmBranch_Info
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
            this.dtpBranch_S_Date = new System.Windows.Forms.DateTimePicker();
            this.lblStartedDate = new System.Windows.Forms.Label();
            this.chkBranch_State = new System.Windows.Forms.CheckBox();
            this.txtBranch_Name = new System.Windows.Forms.TextBox();
            this.txtBranch_ID = new System.Windows.Forms.TextBox();
            this.lblBranch_State = new System.Windows.Forms.Label();
            this.lblBranch_Name = new System.Windows.Forms.Label();
            this.lblBranch_ID = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.btnESC = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.lblENName = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.dgvBranches = new System.Windows.Forms.DataGridView();
            this.pnlOperations.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBranch_S_Date
            // 
            this.dtpBranch_S_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBranch_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBranch_S_Date.Location = new System.Drawing.Point(12, 6);
            this.dtpBranch_S_Date.Name = "dtpBranch_S_Date";
            this.dtpBranch_S_Date.Size = new System.Drawing.Size(253, 30);
            this.dtpBranch_S_Date.TabIndex = 23;
            // 
            // lblStartedDate
            // 
            this.lblStartedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartedDate.AutoSize = true;
            this.lblStartedDate.Location = new System.Drawing.Point(271, 12);
            this.lblStartedDate.Name = "lblStartedDate";
            this.lblStartedDate.Size = new System.Drawing.Size(52, 22);
            this.lblStartedDate.TabIndex = 22;
            this.lblStartedDate.Text = "تاريخ البدء";
            // 
            // chkBranch_State
            // 
            this.chkBranch_State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBranch_State.AutoSize = true;
            this.chkBranch_State.Checked = true;
            this.chkBranch_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBranch_State.ForeColor = System.Drawing.Color.Green;
            this.chkBranch_State.Location = new System.Drawing.Point(214, 42);
            this.chkBranch_State.Name = "chkBranch_State";
            this.chkBranch_State.Size = new System.Drawing.Size(51, 26);
            this.chkBranch_State.TabIndex = 20;
            this.chkBranch_State.Text = "نشط";
            this.chkBranch_State.UseVisualStyleBackColor = true;
            this.chkBranch_State.CheckedChanged += new System.EventHandler(this.chkBranch_State_CheckedChanged);
            // 
            // txtBranch_Name
            // 
            this.txtBranch_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBranch_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBranch_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBranch_Name.Location = new System.Drawing.Point(355, 35);
            this.txtBranch_Name.Name = "txtBranch_Name";
            this.txtBranch_Name.Size = new System.Drawing.Size(250, 23);
            this.txtBranch_Name.TabIndex = 13;
            // 
            // txtBranch_ID
            // 
            this.txtBranch_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBranch_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBranch_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBranch_ID.Location = new System.Drawing.Point(355, 6);
            this.txtBranch_ID.Name = "txtBranch_ID";
            this.txtBranch_ID.ReadOnly = true;
            this.txtBranch_ID.Size = new System.Drawing.Size(250, 23);
            this.txtBranch_ID.TabIndex = 12;
            this.txtBranch_ID.TextChanged += new System.EventHandler(this.txtBranch_ID_TextChanged);
            // 
            // lblBranch_State
            // 
            this.lblBranch_State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_State.AutoSize = true;
            this.lblBranch_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_State.Location = new System.Drawing.Point(271, 44);
            this.lblBranch_State.Name = "lblBranch_State";
            this.lblBranch_State.Size = new System.Drawing.Size(49, 22);
            this.lblBranch_State.TabIndex = 5;
            this.lblBranch_State.Text = "حالة الفرع";
            // 
            // lblBranch_Name
            // 
            this.lblBranch_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_Name.AutoSize = true;
            this.lblBranch_Name.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_Name.Location = new System.Drawing.Point(608, 36);
            this.lblBranch_Name.Name = "lblBranch_Name";
            this.lblBranch_Name.Size = new System.Drawing.Size(53, 22);
            this.lblBranch_Name.TabIndex = 1;
            this.lblBranch_Name.Text = "اسم الفرع";
            // 
            // lblBranch_ID
            // 
            this.lblBranch_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_ID.AutoSize = true;
            this.lblBranch_ID.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_ID.Location = new System.Drawing.Point(608, 5);
            this.lblBranch_ID.Name = "lblBranch_ID";
            this.lblBranch_ID.Size = new System.Drawing.Size(49, 22);
            this.lblBranch_ID.TabIndex = 0;
            this.lblBranch_ID.Text = "رقم الفرع";
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
            this.lblHead.TabIndex = 17;
            this.lblHead.Text = "بيانات الفروع";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlOperations.TabIndex = 25;
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
            this.pnlData.Controls.Add(this.txtEnName);
            this.pnlData.Controls.Add(this.lblENName);
            this.pnlData.Controls.Add(this.pnl2);
            this.pnlData.Controls.Add(this.txtBranch_ID);
            this.pnlData.Controls.Add(this.lblBranch_ID);
            this.pnlData.Controls.Add(this.pnl1);
            this.pnlData.Controls.Add(this.txtBranch_Name);
            this.pnlData.Controls.Add(this.dtpBranch_S_Date);
            this.pnlData.Controls.Add(this.lblBranch_Name);
            this.pnlData.Controls.Add(this.lblStartedDate);
            this.pnlData.Controls.Add(this.chkBranch_State);
            this.pnlData.Controls.Add(this.lblBranch_State);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 80);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(700, 100);
            this.pnlData.TabIndex = 26;
            // 
            // txtEnName
            // 
            this.txtEnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEnName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnName.Location = new System.Drawing.Point(355, 64);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(250, 23);
            this.txtEnName.TabIndex = 29;
            // 
            // lblENName
            // 
            this.lblENName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblENName.AutoSize = true;
            this.lblENName.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblENName.Location = new System.Drawing.Point(608, 65);
            this.lblENName.Name = "lblENName";
            this.lblENName.Size = new System.Drawing.Size(52, 22);
            this.lblENName.TabIndex = 28;
            this.lblENName.Text = "EN Name";
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
            // dgvBranches
            // 
            this.dgvBranches.AllowUserToAddRows = false;
            this.dgvBranches.AllowUserToDeleteRows = false;
            this.dgvBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBranches.Location = new System.Drawing.Point(0, 180);
            this.dgvBranches.Name = "dgvBranches";
            this.dgvBranches.ReadOnly = true;
            this.dgvBranches.Size = new System.Drawing.Size(700, 320);
            this.dgvBranches.TabIndex = 27;
            // 
            // frmBranch_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.dgvBranches);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmBranch_Info";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الفروع ";
            this.Load += new System.EventHandler(this.frmBranch_Info_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBranch_Info_KeyDown);
            this.pnlOperations.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBranch_Name;
        private System.Windows.Forms.TextBox txtBranch_ID;
        private System.Windows.Forms.Label lblBranch_State;
        private System.Windows.Forms.Label lblBranch_Name;
        private System.Windows.Forms.Label lblBranch_ID;
        private System.Windows.Forms.CheckBox chkBranch_State;
        private System.Windows.Forms.DateTimePicker dtpBranch_S_Date;
        private System.Windows.Forms.Label lblStartedDate;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.DataGridView dgvBranches;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.Label lblENName;
    }
}