
namespace appFelxMax.appForms.MenuForms.AccountForms
{
    partial class frmAddEmp
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
            this.txtEmp_ID = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmp_Notes = new System.Windows.Forms.TextBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtEmp_Email = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.txtEmp_Address = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.chkEmp_State = new System.Windows.Forms.CheckBox();
            this.lblEmp_State = new System.Windows.Forms.Label();
            this.dtpEmp_S_Date = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtEmp_Phone = new System.Windows.Forms.TextBox();
            this.txtEmp_Balance = new System.Windows.Forms.TextBox();
            this.txtEmp_Name = new System.Windows.Forms.TextBox();
            this.txtEmp_Code = new System.Windows.Forms.TextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
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
            this.lblHead.Image = global::appFelxMax.Properties.Resources.AddUserColor;
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHead.Size = new System.Drawing.Size(584, 40);
            this.lblHead.TabIndex = 12;
            this.lblHead.Text = "إضافة موظف";
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
            this.pnlMain.Controls.Add(this.txtEmp_ID);
            this.pnlMain.Controls.Add(this.lblEmpID);
            this.pnlMain.Controls.Add(this.txtEmp_Notes);
            this.pnlMain.Controls.Add(this.pnl2);
            this.pnlMain.Controls.Add(this.txtEmp_Email);
            this.pnlMain.Controls.Add(this.txtPeriod);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblRegNumber);
            this.pnlMain.Controls.Add(this.txtEmp_Address);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.lblNotes);
            this.pnlMain.Controls.Add(this.chkEmp_State);
            this.pnlMain.Controls.Add(this.lblEmp_State);
            this.pnlMain.Controls.Add(this.dtpEmp_S_Date);
            this.pnlMain.Controls.Add(this.lblStartDate);
            this.pnlMain.Controls.Add(this.txtEmp_Phone);
            this.pnlMain.Controls.Add(this.txtEmp_Balance);
            this.pnlMain.Controls.Add(this.txtEmp_Name);
            this.pnlMain.Controls.Add(this.txtEmp_Code);
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
            // txtEmp_ID
            // 
            this.txtEmp_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmp_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmp_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmp_ID.Location = new System.Drawing.Point(333, 6);
            this.txtEmp_ID.Name = "txtEmp_ID";
            this.txtEmp_ID.ReadOnly = true;
            this.txtEmp_ID.Size = new System.Drawing.Size(171, 29);
            this.txtEmp_ID.TabIndex = 34;
            // 
            // lblEmpID
            // 
            this.lblEmpID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(510, 6);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(25, 29);
            this.lblEmpID.TabIndex = 33;
            this.lblEmpID.Text = "ID";
            // 
            // txtEmp_Notes
            // 
            this.txtEmp_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmp_Notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmp_Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmp_Notes.Location = new System.Drawing.Point(12, 93);
            this.txtEmp_Notes.Name = "txtEmp_Notes";
            this.txtEmp_Notes.Size = new System.Drawing.Size(171, 29);
            this.txtEmp_Notes.TabIndex = 7;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Silver;
            this.pnl2.Location = new System.Drawing.Point(253, 6);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(17, 174);
            this.pnl2.TabIndex = 31;
            // 
            // txtEmp_Email
            // 
            this.txtEmp_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmp_Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmp_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmp_Email.Location = new System.Drawing.Point(12, 64);
            this.txtEmp_Email.Name = "txtEmp_Email";
            this.txtEmp_Email.Size = new System.Drawing.Size(171, 29);
            this.txtEmp_Email.TabIndex = 6;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriod.Location = new System.Drawing.Point(333, 122);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(171, 29);
            this.txtPeriod.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(189, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 29);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(510, 122);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(41, 29);
            this.lblRegNumber.TabIndex = 27;
            this.lblRegNumber.Text = "المدة";
            // 
            // txtEmp_Address
            // 
            this.txtEmp_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmp_Address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmp_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmp_Address.Location = new System.Drawing.Point(11, 35);
            this.txtEmp_Address.Name = "txtEmp_Address";
            this.txtEmp_Address.Size = new System.Drawing.Size(171, 29);
            this.txtEmp_Address.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(188, 35);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 29);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Text = "العنوان";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(189, 93);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(59, 29);
            this.lblNotes.TabIndex = 23;
            this.lblNotes.Text = "ملاحظات";
            // 
            // chkEmp_State
            // 
            this.chkEmp_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEmp_State.AutoSize = true;
            this.chkEmp_State.Checked = true;
            this.chkEmp_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmp_State.ForeColor = System.Drawing.Color.Green;
            this.chkEmp_State.Location = new System.Drawing.Point(120, 158);
            this.chkEmp_State.Name = "chkEmp_State";
            this.chkEmp_State.Size = new System.Drawing.Size(63, 33);
            this.chkEmp_State.TabIndex = 9;
            this.chkEmp_State.Text = "نشط";
            this.chkEmp_State.UseVisualStyleBackColor = true;
            // 
            // lblEmp_State
            // 
            this.lblEmp_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmp_State.AutoSize = true;
            this.lblEmp_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblEmp_State.Location = new System.Drawing.Point(189, 158);
            this.lblEmp_State.Name = "lblEmp_State";
            this.lblEmp_State.Size = new System.Drawing.Size(78, 29);
            this.lblEmp_State.TabIndex = 21;
            this.lblEmp_State.Text = "حالة الموظف";
            // 
            // dtpEmp_S_Date
            // 
            this.dtpEmp_S_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEmp_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmp_S_Date.Location = new System.Drawing.Point(14, 122);
            this.dtpEmp_S_Date.Name = "dtpEmp_S_Date";
            this.dtpEmp_S_Date.Size = new System.Drawing.Size(169, 36);
            this.dtpEmp_S_Date.TabIndex = 8;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(189, 122);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(67, 29);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "تاريخ البدء";
            // 
            // txtEmp_Phone
            // 
            this.txtEmp_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmp_Phone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmp_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmp_Phone.Location = new System.Drawing.Point(11, 6);
            this.txtEmp_Phone.Name = "txtEmp_Phone";
            this.txtEmp_Phone.Size = new System.Drawing.Size(171, 29);
            this.txtEmp_Phone.TabIndex = 3;
            // 
            // txtEmp_Balance
            // 
            this.txtEmp_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmp_Balance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmp_Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmp_Balance.Location = new System.Drawing.Point(333, 93);
            this.txtEmp_Balance.Name = "txtEmp_Balance";
            this.txtEmp_Balance.Size = new System.Drawing.Size(171, 29);
            this.txtEmp_Balance.TabIndex = 2;
            // 
            // txtEmp_Name
            // 
            this.txtEmp_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmp_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmp_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmp_Name.Location = new System.Drawing.Point(333, 64);
            this.txtEmp_Name.Name = "txtEmp_Name";
            this.txtEmp_Name.Size = new System.Drawing.Size(171, 29);
            this.txtEmp_Name.TabIndex = 1;
            // 
            // txtEmp_Code
            // 
            this.txtEmp_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmp_Code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmp_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmp_Code.Location = new System.Drawing.Point(333, 35);
            this.txtEmp_Code.Name = "txtEmp_Code";
            this.txtEmp_Code.ReadOnly = true;
            this.txtEmp_Code.Size = new System.Drawing.Size(171, 29);
            this.txtEmp_Code.TabIndex = 4;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Silver;
            this.pnl1.Location = new System.Drawing.Point(559, 6);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(17, 174);
            this.pnl1.TabIndex = 0;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(188, 6);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 29);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "الهاتف";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(510, 93);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(44, 29);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "الراتب";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(510, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 29);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "اسم";
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(510, 35);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(34, 29);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "كود";
            // 
            // frmAddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
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
            this.Name = "frmAddEmp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "اضافة موظف";
            this.Load += new System.EventHandler(this.frmAddEmp_Load);
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
        private System.Windows.Forms.TextBox txtEmp_ID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtEmp_Notes;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.TextBox txtEmp_Email;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.TextBox txtEmp_Address;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.CheckBox chkEmp_State;
        private System.Windows.Forms.Label lblEmp_State;
        private System.Windows.Forms.DateTimePicker dtpEmp_S_Date;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtEmp_Phone;
        private System.Windows.Forms.TextBox txtEmp_Balance;
        private System.Windows.Forms.TextBox txtEmp_Name;
        private System.Windows.Forms.TextBox txtEmp_Code;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
    }
}