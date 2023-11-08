
namespace appFelxMax.appForms.SubForms
{
    partial class frmAdd_Cust
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
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.btnESC = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtCust_Notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkCust_State = new System.Windows.Forms.CheckBox();
            this.lblBranch_State = new System.Windows.Forms.Label();
            this.dtpCust_S_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCust_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCust_Mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCust_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCust_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCust_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.pnlOperations.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOperations.Controls.Add(this.btnESC);
            this.pnlOperations.Controls.Add(this.btnSave);
            this.pnlOperations.Controls.Add(this.btnNew);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 40);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(584, 52);
            this.pnlOperations.TabIndex = 12;
            // 
            // btnESC
            // 
            this.btnESC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnESC.FlatAppearance.BorderSize = 0;
            this.btnESC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESC.ForeColor = System.Drawing.Color.White;
            this.btnESC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnESC.Location = new System.Drawing.Point(147, 6);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(100, 41);
            this.btnESC.TabIndex = 14;
            this.btnESC.Text = "خروج - ESC";
            this.btnESC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnESC.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(253, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 41);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ - F2";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(359, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 41);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Controls.Add(this.txtCust_Notes);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.chkCust_State);
            this.pnlMain.Controls.Add(this.lblBranch_State);
            this.pnlMain.Controls.Add(this.dtpCust_S_Date);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtCust_Address);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtCust_Mobile);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.txtCust_Name);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtCust_Code);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtCust_ID);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 92);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 174);
            this.pnlMain.TabIndex = 13;
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // txtCust_Notes
            // 
            this.txtCust_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCust_Notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCust_Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCust_Notes.Location = new System.Drawing.Point(46, 132);
            this.txtCust_Notes.Multiline = true;
            this.txtCust_Notes.Name = "txtCust_Notes";
            this.txtCust_Notes.Size = new System.Drawing.Size(171, 29);
            this.txtCust_Notes.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "ملاحظات";
            // 
            // chkCust_State
            // 
            this.chkCust_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCust_State.AutoSize = true;
            this.chkCust_State.Checked = true;
            this.chkCust_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCust_State.ForeColor = System.Drawing.Color.Green;
            this.chkCust_State.Location = new System.Drawing.Point(404, 131);
            this.chkCust_State.Name = "chkCust_State";
            this.chkCust_State.Size = new System.Drawing.Size(63, 33);
            this.chkCust_State.TabIndex = 22;
            this.chkCust_State.Text = "نشط";
            this.chkCust_State.UseVisualStyleBackColor = true;
            this.chkCust_State.CheckedChanged += new System.EventHandler(this.chkCust_State_CheckedChanged);
            // 
            // lblBranch_State
            // 
            this.lblBranch_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_State.AutoSize = true;
            this.lblBranch_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_State.Location = new System.Drawing.Point(479, 131);
            this.lblBranch_State.Name = "lblBranch_State";
            this.lblBranch_State.Size = new System.Drawing.Size(73, 29);
            this.lblBranch_State.TabIndex = 21;
            this.lblBranch_State.Text = "حالة العميل";
            // 
            // dtpCust_S_Date
            // 
            this.dtpCust_S_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCust_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCust_S_Date.Location = new System.Drawing.Point(46, 93);
            this.dtpCust_S_Date.Name = "dtpCust_S_Date";
            this.dtpCust_S_Date.Size = new System.Drawing.Size(171, 36);
            this.dtpCust_S_Date.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "تاريخ البدء";
            // 
            // txtCust_Address
            // 
            this.txtCust_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCust_Address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCust_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCust_Address.Location = new System.Drawing.Point(46, 54);
            this.txtCust_Address.Name = "txtCust_Address";
            this.txtCust_Address.Size = new System.Drawing.Size(171, 29);
            this.txtCust_Address.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "العنوان";
            // 
            // txtCust_Mobile
            // 
            this.txtCust_Mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCust_Mobile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCust_Mobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCust_Mobile.Location = new System.Drawing.Point(46, 16);
            this.txtCust_Mobile.Name = "txtCust_Mobile";
            this.txtCust_Mobile.Size = new System.Drawing.Size(171, 29);
            this.txtCust_Mobile.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "الهاتف";
            // 
            // txtCust_Name
            // 
            this.txtCust_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCust_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCust_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCust_Name.Location = new System.Drawing.Point(299, 93);
            this.txtCust_Name.Name = "txtCust_Name";
            this.txtCust_Name.Size = new System.Drawing.Size(171, 29);
            this.txtCust_Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسم";
            // 
            // txtCust_Code
            // 
            this.txtCust_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCust_Code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCust_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCust_Code.Location = new System.Drawing.Point(300, 55);
            this.txtCust_Code.Name = "txtCust_Code";
            this.txtCust_Code.Size = new System.Drawing.Size(171, 29);
            this.txtCust_Code.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "كود";
            // 
            // txtCust_ID
            // 
            this.txtCust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCust_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCust_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCust_ID.Location = new System.Drawing.Point(302, 17);
            this.txtCust_ID.Name = "txtCust_ID";
            this.txtCust_ID.Size = new System.Drawing.Size(171, 29);
            this.txtCust_ID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Location = new System.Drawing.Point(559, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 154);
            this.panel1.TabIndex = 0;
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
            this.lblHead.Size = new System.Drawing.Size(584, 40);
            this.lblHead.TabIndex = 11;
            this.lblHead.Text = "إضافة عميل";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdd_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 266);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd_Cust";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة عميل";
            this.Load += new System.EventHandler(this.frmAdd_Cust_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdd_Cust_KeyDown);
            this.pnlOperations.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCust_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCust_S_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCust_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCust_Mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCust_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCust_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.TextBox txtCust_Notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkCust_State;
        private System.Windows.Forms.Label lblBranch_State;
    }
}