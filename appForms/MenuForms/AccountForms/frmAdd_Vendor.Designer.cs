
namespace appFelxMax.appForms.SubForms
{
    partial class frmAdd_Vendor
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtVend_Notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkVend_State = new System.Windows.Forms.CheckBox();
            this.lblBranch_State = new System.Windows.Forms.Label();
            this.dtpVend_S_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVend_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVend_Mobil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVend_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVend_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVend_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOperations.SuspendLayout();
            this.pnlMain.SuspendLayout();
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
            this.lblHead.Size = new System.Drawing.Size(591, 46);
            this.lblHead.TabIndex = 12;
            this.lblHead.Text = "إضافة مورد ";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOperations.Controls.Add(this.btnESC);
            this.pnlOperations.Controls.Add(this.btnSave);
            this.pnlOperations.Controls.Add(this.btnNew);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 46);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(591, 60);
            this.pnlOperations.TabIndex = 13;
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
            this.btnESC.Location = new System.Drawing.Point(154, 7);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(100, 48);
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
            this.btnSave.Location = new System.Drawing.Point(260, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 48);
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
            this.btnNew.Location = new System.Drawing.Point(366, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 48);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Controls.Add(this.txtVend_Notes);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.chkVend_State);
            this.pnlMain.Controls.Add(this.lblBranch_State);
            this.pnlMain.Controls.Add(this.dtpVend_S_Date);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtVend_Address);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtVend_Mobil);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.txtVend_Name);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtVend_Code);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtVend_ID);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 106);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(591, 195);
            this.pnlMain.TabIndex = 14;
            // 
            // txtVend_Notes
            // 
            this.txtVend_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVend_Notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVend_Notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVend_Notes.Location = new System.Drawing.Point(49, 153);
            this.txtVend_Notes.Multiline = true;
            this.txtVend_Notes.Name = "txtVend_Notes";
            this.txtVend_Notes.Size = new System.Drawing.Size(171, 29);
            this.txtVend_Notes.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "ملاحظات";
            // 
            // chkVend_State
            // 
            this.chkVend_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVend_State.AutoSize = true;
            this.chkVend_State.Checked = true;
            this.chkVend_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVend_State.ForeColor = System.Drawing.Color.Green;
            this.chkVend_State.Location = new System.Drawing.Point(407, 152);
            this.chkVend_State.Name = "chkVend_State";
            this.chkVend_State.Size = new System.Drawing.Size(63, 33);
            this.chkVend_State.TabIndex = 26;
            this.chkVend_State.Text = "نشط";
            this.chkVend_State.UseVisualStyleBackColor = true;
            this.chkVend_State.CheckedChanged += new System.EventHandler(this.chkVend_State_CheckedChanged);
            // 
            // lblBranch_State
            // 
            this.lblBranch_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch_State.AutoSize = true;
            this.lblBranch_State.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.lblBranch_State.Location = new System.Drawing.Point(482, 152);
            this.lblBranch_State.Name = "lblBranch_State";
            this.lblBranch_State.Size = new System.Drawing.Size(67, 29);
            this.lblBranch_State.TabIndex = 25;
            this.lblBranch_State.Text = "حالة المورد";
            // 
            // dtpVend_S_Date
            // 
            this.dtpVend_S_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVend_S_Date.Location = new System.Drawing.Point(46, 108);
            this.dtpVend_S_Date.Name = "dtpVend_S_Date";
            this.dtpVend_S_Date.Size = new System.Drawing.Size(171, 36);
            this.dtpVend_S_Date.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "تاريخ البدء";
            // 
            // txtVend_Address
            // 
            this.txtVend_Address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVend_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVend_Address.Location = new System.Drawing.Point(46, 63);
            this.txtVend_Address.Name = "txtVend_Address";
            this.txtVend_Address.Size = new System.Drawing.Size(171, 29);
            this.txtVend_Address.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "العنوان";
            // 
            // txtVend_Mobil
            // 
            this.txtVend_Mobil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVend_Mobil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVend_Mobil.Location = new System.Drawing.Point(46, 19);
            this.txtVend_Mobil.Name = "txtVend_Mobil";
            this.txtVend_Mobil.Size = new System.Drawing.Size(171, 29);
            this.txtVend_Mobil.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "الهاتف";
            // 
            // txtVend_Name
            // 
            this.txtVend_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVend_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVend_Name.Location = new System.Drawing.Point(299, 108);
            this.txtVend_Name.Name = "txtVend_Name";
            this.txtVend_Name.Size = new System.Drawing.Size(171, 29);
            this.txtVend_Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسم";
            // 
            // txtVend_Code
            // 
            this.txtVend_Code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVend_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVend_Code.Location = new System.Drawing.Point(300, 64);
            this.txtVend_Code.Name = "txtVend_Code";
            this.txtVend_Code.Size = new System.Drawing.Size(171, 29);
            this.txtVend_Code.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "كود";
            // 
            // txtVend_ID
            // 
            this.txtVend_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVend_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVend_ID.Location = new System.Drawing.Point(302, 20);
            this.txtVend_ID.Name = "txtVend_ID";
            this.txtVend_ID.Size = new System.Drawing.Size(171, 29);
            this.txtVend_ID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Location = new System.Drawing.Point(561, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 174);
            this.panel1.TabIndex = 0;
            // 
            // frmAdd_Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 301);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmAdd_Vendor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مورد";
            this.Load += new System.EventHandler(this.frmAdd_Vendor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdd_Vendor_KeyDown);
            this.pnlOperations.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DateTimePicker dtpVend_S_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVend_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVend_Mobil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVend_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVend_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVend_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVend_Notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkVend_State;
        private System.Windows.Forms.Label lblBranch_State;
    }
}