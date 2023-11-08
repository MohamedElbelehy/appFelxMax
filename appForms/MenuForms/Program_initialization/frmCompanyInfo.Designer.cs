
namespace appFelxMax.appForms.MenuForms
{
    partial class frmCompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyInfo));
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblComRec = new System.Windows.Forms.Label();
            this.txtComRec = new System.Windows.Forms.TextBox();
            this.lblTaxCard = new System.Windows.Forms.Label();
            this.txtTaxCard = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtCompanyNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(102, 43);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(260, 36);
            this.txtCompanyID.TabIndex = 0;
            this.txtCompanyID.TextChanged += new System.EventHandler(this.txtCompanyID_TextChanged);
            this.txtCompanyID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyID_KeyDown);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ForeColor = System.Drawing.Color.Black;
            this.lblServerName.Location = new System.Drawing.Point(12, 46);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(88, 29);
            this.lblServerName.TabIndex = 9;
            this.lblServerName.Text = "الرقم التعريفي";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(34, 124);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 29);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "رقم الهاتف";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 121);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 36);
            this.txtPhone.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(52, 163);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 29);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "العنوان";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 160);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 36);
            this.txtAddress.TabIndex = 2;
            // 
            // lblComRec
            // 
            this.lblComRec.AutoSize = true;
            this.lblComRec.ForeColor = System.Drawing.Color.Black;
            this.lblComRec.Location = new System.Drawing.Point(59, 202);
            this.lblComRec.Name = "lblComRec";
            this.lblComRec.Size = new System.Drawing.Size(45, 29);
            this.lblComRec.TabIndex = 12;
            this.lblComRec.Text = "س.ت";
            // 
            // txtComRec
            // 
            this.txtComRec.Location = new System.Drawing.Point(102, 199);
            this.txtComRec.Name = "txtComRec";
            this.txtComRec.Size = new System.Drawing.Size(260, 36);
            this.txtComRec.TabIndex = 3;
            // 
            // lblTaxCard
            // 
            this.lblTaxCard.AutoSize = true;
            this.lblTaxCard.ForeColor = System.Drawing.Color.Black;
            this.lblTaxCard.Location = new System.Drawing.Point(60, 241);
            this.lblTaxCard.Name = "lblTaxCard";
            this.lblTaxCard.Size = new System.Drawing.Size(44, 29);
            this.lblTaxCard.TabIndex = 13;
            this.lblTaxCard.Text = "ب.ض";
            // 
            // txtTaxCard
            // 
            this.txtTaxCard.Location = new System.Drawing.Point(102, 238);
            this.txtTaxCard.Name = "txtTaxCard";
            this.txtTaxCard.Size = new System.Drawing.Size(260, 36);
            this.txtTaxCard.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(458, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(368, 223);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpload.Size = new System.Drawing.Size(85, 30);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "تحميل";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(102, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(80, 0, 90, 0);
            this.btnSave.Size = new System.Drawing.Size(260, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(604, 40);
            this.lblHead.TabIndex = 8;
            this.lblHead.Text = "بيانات المؤسسة";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(368, 43);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(175, 174);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // txtCompanyNote
            // 
            this.txtCompanyNote.Location = new System.Drawing.Point(102, 277);
            this.txtCompanyNote.Name = "txtCompanyNote";
            this.txtCompanyNote.Size = new System.Drawing.Size(260, 36);
            this.txtCompanyNote.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "ملاحظات";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(102, 82);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(260, 36);
            this.txtCompanyName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "اسم المؤسسة";
            // 
            // frmCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 365);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTaxCard);
            this.Controls.Add(this.txtComRec);
            this.Controls.Add(this.lblTaxCard);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblComRec);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblServerName);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanyInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات المؤسسه";
            this.Load += new System.EventHandler(this.frmCompanyInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblComRec;
        private System.Windows.Forms.TextBox txtComRec;
        private System.Windows.Forms.Label lblTaxCard;
        private System.Windows.Forms.TextBox txtTaxCard;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCompanyNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
    }
}