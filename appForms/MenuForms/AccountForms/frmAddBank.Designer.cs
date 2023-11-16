
namespace appFelxMax.appForms.MenuForms.AccountForms
{
    partial class frmAddBank
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
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cmbBankBranch = new System.Windows.Forms.ComboBox();
            this.txtBankID = new System.Windows.Forms.TextBox();
            this.lblBankID = new System.Windows.Forms.Label();
            this.txtBankNotes = new System.Windows.Forms.TextBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtBankAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.chkBankState = new System.Windows.Forms.CheckBox();
            this.lblBankState = new System.Windows.Forms.Label();
            this.dtpBank_S_Date = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtBankBalance = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnESC = new System.Windows.Forms.Button();
            this.pnlOperation.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHead.Image = global::appFelxMax.Properties.Resources.AddColor;
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHead.Size = new System.Drawing.Size(584, 40);
            this.lblHead.TabIndex = 13;
            this.lblHead.Text = "إضافة بنك";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.Color.LightGray;
            this.pnlOperation.Controls.Add(this.btnESC);
            this.pnlOperation.Controls.Add(this.btnSave);
            this.pnlOperation.Controls.Add(this.btnNew);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 40);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(584, 40);
            this.pnlOperation.TabIndex = 18;
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
            this.btnSave.Location = new System.Drawing.Point(406, 3);
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
            this.btnNew.Location = new System.Drawing.Point(492, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Controls.Add(this.cmbBankBranch);
            this.pnlMain.Controls.Add(this.txtBankID);
            this.pnlMain.Controls.Add(this.lblBankID);
            this.pnlMain.Controls.Add(this.txtBankNotes);
            this.pnlMain.Controls.Add(this.pnl2);
            this.pnlMain.Controls.Add(this.txtBankAddress);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.lblNotes);
            this.pnlMain.Controls.Add(this.chkBankState);
            this.pnlMain.Controls.Add(this.lblBankState);
            this.pnlMain.Controls.Add(this.dtpBank_S_Date);
            this.pnlMain.Controls.Add(this.lblStartDate);
            this.pnlMain.Controls.Add(this.txtBankBalance);
            this.pnlMain.Controls.Add(this.txtBankName);
            this.pnlMain.Controls.Add(this.txtBankCode);
            this.pnlMain.Controls.Add(this.pnl1);
            this.pnlMain.Controls.Add(this.lblBranch);
            this.pnlMain.Controls.Add(this.lblBalance);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.lblCode);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 211);
            this.pnlMain.TabIndex = 19;
            // 
            // cmbBankBranch
            // 
            this.cmbBankBranch.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBankBranch.FormattingEnabled = true;
            this.cmbBankBranch.Location = new System.Drawing.Point(333, 122);
            this.cmbBankBranch.Name = "cmbBankBranch";
            this.cmbBankBranch.Size = new System.Drawing.Size(171, 26);
            this.cmbBankBranch.TabIndex = 3;
            // 
            // txtBankID
            // 
            this.txtBankID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBankID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankID.Location = new System.Drawing.Point(333, 6);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.ReadOnly = true;
            this.txtBankID.Size = new System.Drawing.Size(171, 23);
            this.txtBankID.TabIndex = 34;
            // 
            // lblBankID
            // 
            this.lblBankID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankID.AutoSize = true;
            this.lblBankID.Location = new System.Drawing.Point(510, 6);
            this.lblBankID.Name = "lblBankID";
            this.lblBankID.Size = new System.Drawing.Size(20, 22);
            this.lblBankID.TabIndex = 33;
            this.lblBankID.Text = "ID";
            // 
            // txtBankNotes
            // 
            this.txtBankNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBankNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankNotes.Location = new System.Drawing.Point(12, 6);
            this.txtBankNotes.Name = "txtBankNotes";
            this.txtBankNotes.Size = new System.Drawing.Size(171, 23);
            this.txtBankNotes.TabIndex = 6;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Silver;
            this.pnl2.Location = new System.Drawing.Point(253, 6);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(17, 171);
            this.pnl2.TabIndex = 31;
            // 
            // txtBankAddress
            // 
            this.txtBankAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBankAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankAddress.Location = new System.Drawing.Point(333, 154);
            this.txtBankAddress.Name = "txtBankAddress";
            this.txtBankAddress.Size = new System.Drawing.Size(171, 23);
            this.txtBankAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(510, 154);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 22);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Text = "العنوان";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(189, 6);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(48, 22);
            this.lblNotes.TabIndex = 23;
            this.lblNotes.Text = "ملاحظات";
            // 
            // chkBankState
            // 
            this.chkBankState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBankState.AutoSize = true;
            this.chkBankState.Checked = true;
            this.chkBankState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBankState.ForeColor = System.Drawing.Color.Green;
            this.chkBankState.Location = new System.Drawing.Point(132, 71);
            this.chkBankState.Name = "chkBankState";
            this.chkBankState.Size = new System.Drawing.Size(51, 26);
            this.chkBankState.TabIndex = 8;
            this.chkBankState.Text = "نشط";
            this.chkBankState.UseVisualStyleBackColor = true;
            // 
            // lblBankState
            // 
            this.lblBankState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankState.AutoSize = true;
            this.lblBankState.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBankState.Location = new System.Drawing.Point(189, 71);
            this.lblBankState.Name = "lblBankState";
            this.lblBankState.Size = new System.Drawing.Size(54, 22);
            this.lblBankState.TabIndex = 21;
            this.lblBankState.Text = "حالة الخزنة ";
            // 
            // dtpBank_S_Date
            // 
            this.dtpBank_S_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBank_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBank_S_Date.Location = new System.Drawing.Point(12, 35);
            this.dtpBank_S_Date.Name = "dtpBank_S_Date";
            this.dtpBank_S_Date.Size = new System.Drawing.Size(171, 30);
            this.dtpBank_S_Date.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(189, 35);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(52, 22);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "تاريخ البدء";
            // 
            // txtBankBalance
            // 
            this.txtBankBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBankBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankBalance.Location = new System.Drawing.Point(333, 93);
            this.txtBankBalance.Name = "txtBankBalance";
            this.txtBankBalance.Size = new System.Drawing.Size(171, 23);
            this.txtBankBalance.TabIndex = 2;
            // 
            // txtBankName
            // 
            this.txtBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankName.Location = new System.Drawing.Point(333, 64);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(171, 23);
            this.txtBankName.TabIndex = 1;
            // 
            // txtBankCode
            // 
            this.txtBankCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBankCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankCode.Location = new System.Drawing.Point(333, 35);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.ReadOnly = true;
            this.txtBankCode.Size = new System.Drawing.Size(171, 23);
            this.txtBankCode.TabIndex = 4;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Silver;
            this.pnl1.Location = new System.Drawing.Point(559, 6);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(17, 171);
            this.pnl1.TabIndex = 0;
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(510, 122);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(31, 22);
            this.lblBranch.TabIndex = 9;
            this.lblBranch.Text = "الفرع";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(510, 93);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(36, 22);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "الرصيد";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(510, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 22);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "اسم";
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(510, 35);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(27, 22);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "كود";
            // 
            // btnESC
            // 
            this.btnESC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnESC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnESC.FlatAppearance.BorderSize = 0;
            this.btnESC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESC.ForeColor = System.Drawing.Color.Black;
            this.btnESC.Image = global::appFelxMax.Properties.Resources.EscColor;
            this.btnESC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnESC.Location = new System.Drawing.Point(310, 3);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(90, 30);
            this.btnESC.TabIndex = 14;
            this.btnESC.Text = "خروج";
            this.btnESC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnESC.UseVisualStyleBackColor = false;
            // 
            // frmAddBank
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlOperation);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBank";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة بنك";
            this.pnlOperation.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cmbBankBranch;
        private System.Windows.Forms.TextBox txtBankID;
        private System.Windows.Forms.Label lblBankID;
        private System.Windows.Forms.TextBox txtBankNotes;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.TextBox txtBankAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.CheckBox chkBankState;
        private System.Windows.Forms.Label lblBankState;
        private System.Windows.Forms.DateTimePicker dtpBank_S_Date;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtBankBalance;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnESC;
    }
}