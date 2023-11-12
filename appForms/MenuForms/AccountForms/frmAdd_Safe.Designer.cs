
namespace appFelxMax.appForms.MenuForms.AccountForms
{
    partial class frmAdd_Safe
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
            this.btnESC = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtSafe_ID = new System.Windows.Forms.TextBox();
            this.lblSafeID = new System.Windows.Forms.Label();
            this.txtSafe_Notes = new System.Windows.Forms.TextBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.chkSafe_State = new System.Windows.Forms.CheckBox();
            this.lblSafe_State = new System.Windows.Forms.Label();
            this.dtpSafe_S_Date = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtSafe_Balance = new System.Windows.Forms.TextBox();
            this.txtSafe_Name = new System.Windows.Forms.TextBox();
            this.txSafe_Code = new System.Windows.Forms.TextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSafe_Address = new System.Windows.Forms.TextBox();
            this.cmbSafe_Branch = new System.Windows.Forms.ComboBox();
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
            this.lblHead.TabIndex = 12;
            this.lblHead.Text = "إضافة خزنة";
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
            this.pnlOperation.TabIndex = 17;
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
            this.btnESC.Location = new System.Drawing.Point(310, 3);
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
            this.pnlMain.Controls.Add(this.cmbSafe_Branch);
            this.pnlMain.Controls.Add(this.txtSafe_ID);
            this.pnlMain.Controls.Add(this.lblSafeID);
            this.pnlMain.Controls.Add(this.txtSafe_Notes);
            this.pnlMain.Controls.Add(this.pnl2);
            this.pnlMain.Controls.Add(this.txtSafe_Address);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.lblNotes);
            this.pnlMain.Controls.Add(this.chkSafe_State);
            this.pnlMain.Controls.Add(this.lblSafe_State);
            this.pnlMain.Controls.Add(this.dtpSafe_S_Date);
            this.pnlMain.Controls.Add(this.lblStartDate);
            this.pnlMain.Controls.Add(this.txtSafe_Balance);
            this.pnlMain.Controls.Add(this.txtSafe_Name);
            this.pnlMain.Controls.Add(this.txSafe_Code);
            this.pnlMain.Controls.Add(this.pnl1);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.lblBalance);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.lblCode);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 211);
            this.pnlMain.TabIndex = 18;
            // 
            // txtSafe_ID
            // 
            this.txtSafe_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSafe_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSafe_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSafe_ID.Location = new System.Drawing.Point(333, 6);
            this.txtSafe_ID.Name = "txtSafe_ID";
            this.txtSafe_ID.Size = new System.Drawing.Size(171, 23);
            this.txtSafe_ID.TabIndex = 34;
            // 
            // lblSafeID
            // 
            this.lblSafeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSafeID.AutoSize = true;
            this.lblSafeID.Location = new System.Drawing.Point(510, 6);
            this.lblSafeID.Name = "lblSafeID";
            this.lblSafeID.Size = new System.Drawing.Size(20, 22);
            this.lblSafeID.TabIndex = 33;
            this.lblSafeID.Text = "ID";
            // 
            // txtSafe_Notes
            // 
            this.txtSafe_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSafe_Notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSafe_Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSafe_Notes.Location = new System.Drawing.Point(12, 6);
            this.txtSafe_Notes.Name = "txtSafe_Notes";
            this.txtSafe_Notes.Size = new System.Drawing.Size(171, 23);
            this.txtSafe_Notes.TabIndex = 32;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Silver;
            this.pnl2.Location = new System.Drawing.Point(253, 6);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(17, 171);
            this.pnl2.TabIndex = 31;
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
            // chkSafe_State
            // 
            this.chkSafe_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSafe_State.AutoSize = true;
            this.chkSafe_State.Checked = true;
            this.chkSafe_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSafe_State.ForeColor = System.Drawing.Color.Green;
            this.chkSafe_State.Location = new System.Drawing.Point(132, 71);
            this.chkSafe_State.Name = "chkSafe_State";
            this.chkSafe_State.Size = new System.Drawing.Size(51, 26);
            this.chkSafe_State.TabIndex = 22;
            this.chkSafe_State.Text = "نشط";
            this.chkSafe_State.UseVisualStyleBackColor = true;
            // 
            // lblSafe_State
            // 
            this.lblSafe_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSafe_State.AutoSize = true;
            this.lblSafe_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblSafe_State.Location = new System.Drawing.Point(189, 71);
            this.lblSafe_State.Name = "lblSafe_State";
            this.lblSafe_State.Size = new System.Drawing.Size(54, 22);
            this.lblSafe_State.TabIndex = 21;
            this.lblSafe_State.Text = "حالة الخزنة ";
            // 
            // dtpSafe_S_Date
            // 
            this.dtpSafe_S_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSafe_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSafe_S_Date.Location = new System.Drawing.Point(12, 35);
            this.dtpSafe_S_Date.Name = "dtpSafe_S_Date";
            this.dtpSafe_S_Date.Size = new System.Drawing.Size(171, 30);
            this.dtpSafe_S_Date.TabIndex = 12;
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
            // txtSafe_Balance
            // 
            this.txtSafe_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSafe_Balance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSafe_Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSafe_Balance.Location = new System.Drawing.Point(333, 93);
            this.txtSafe_Balance.Name = "txtSafe_Balance";
            this.txtSafe_Balance.Size = new System.Drawing.Size(171, 23);
            this.txtSafe_Balance.TabIndex = 8;
            // 
            // txtSafe_Name
            // 
            this.txtSafe_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSafe_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSafe_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSafe_Name.Location = new System.Drawing.Point(333, 64);
            this.txtSafe_Name.Name = "txtSafe_Name";
            this.txtSafe_Name.Size = new System.Drawing.Size(171, 23);
            this.txtSafe_Name.TabIndex = 6;
            // 
            // txSafe_Code
            // 
            this.txSafe_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txSafe_Code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txSafe_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSafe_Code.Location = new System.Drawing.Point(333, 35);
            this.txSafe_Code.Name = "txSafe_Code";
            this.txSafe_Code.Size = new System.Drawing.Size(171, 23);
            this.txSafe_Code.TabIndex = 4;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Silver;
            this.pnl1.Location = new System.Drawing.Point(559, 6);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(17, 171);
            this.pnl1.TabIndex = 0;
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
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(510, 122);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(31, 22);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "الفرع";
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
            // txtSafe_Address
            // 
            this.txtSafe_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSafe_Address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSafe_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSafe_Address.Location = new System.Drawing.Point(333, 154);
            this.txtSafe_Address.Name = "txtSafe_Address";
            this.txtSafe_Address.Size = new System.Drawing.Size(171, 23);
            this.txtSafe_Address.TabIndex = 26;
            // 
            // cmbSafe_Branch
            // 
            this.cmbSafe_Branch.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSafe_Branch.FormattingEnabled = true;
            this.cmbSafe_Branch.Location = new System.Drawing.Point(333, 122);
            this.cmbSafe_Branch.Name = "cmbSafe_Branch";
            this.cmbSafe_Branch.Size = new System.Drawing.Size(171, 26);
            this.cmbSafe_Branch.TabIndex = 35;
            // 
            // frmAdd_Safe
            // 
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
            this.Name = "frmAdd_Safe";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافة خزنة";
            this.pnlOperation.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtSafe_ID;
        private System.Windows.Forms.Label lblSafeID;
        private System.Windows.Forms.TextBox txtSafe_Notes;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.CheckBox chkSafe_State;
        private System.Windows.Forms.Label lblSafe_State;
        private System.Windows.Forms.DateTimePicker dtpSafe_S_Date;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtSafe_Balance;
        private System.Windows.Forms.TextBox txtSafe_Name;
        private System.Windows.Forms.TextBox txSafe_Code;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cmbSafe_Branch;
        private System.Windows.Forms.TextBox txtSafe_Address;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
    }
}