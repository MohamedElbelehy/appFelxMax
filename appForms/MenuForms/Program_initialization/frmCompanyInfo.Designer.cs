
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
            this.txtCompanyNote = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.btnESC = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUploud = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(102, 86);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(260, 30);
            this.txtCompanyID.TabIndex = 0;
            this.txtCompanyID.TextChanged += new System.EventHandler(this.txtCompanyID_TextChanged);
            this.txtCompanyID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyID_KeyDown);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ForeColor = System.Drawing.Color.Black;
            this.lblServerName.Location = new System.Drawing.Point(14, 89);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(72, 22);
            this.lblServerName.TabIndex = 9;
            this.lblServerName.Text = "الرقم التعريفي";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(29, 167);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(57, 22);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "رقم الهاتف";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 164);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 30);
            this.txtPhone.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(43, 206);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 22);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "العنوان";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 203);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 30);
            this.txtAddress.TabIndex = 2;
            // 
            // lblComRec
            // 
            this.lblComRec.AutoSize = true;
            this.lblComRec.ForeColor = System.Drawing.Color.Black;
            this.lblComRec.Location = new System.Drawing.Point(49, 245);
            this.lblComRec.Name = "lblComRec";
            this.lblComRec.Size = new System.Drawing.Size(37, 22);
            this.lblComRec.TabIndex = 12;
            this.lblComRec.Text = "س.ت";
            // 
            // txtComRec
            // 
            this.txtComRec.Location = new System.Drawing.Point(102, 242);
            this.txtComRec.Name = "txtComRec";
            this.txtComRec.Size = new System.Drawing.Size(260, 30);
            this.txtComRec.TabIndex = 3;
            // 
            // lblTaxCard
            // 
            this.lblTaxCard.AutoSize = true;
            this.lblTaxCard.ForeColor = System.Drawing.Color.Black;
            this.lblTaxCard.Location = new System.Drawing.Point(50, 284);
            this.lblTaxCard.Name = "lblTaxCard";
            this.lblTaxCard.Size = new System.Drawing.Size(36, 22);
            this.lblTaxCard.TabIndex = 13;
            this.lblTaxCard.Text = "ب.ض";
            // 
            // txtTaxCard
            // 
            this.txtTaxCard.Location = new System.Drawing.Point(102, 281);
            this.txtTaxCard.Name = "txtTaxCard";
            this.txtTaxCard.Size = new System.Drawing.Size(260, 30);
            this.txtTaxCard.TabIndex = 4;
            // 
            // txtCompanyNote
            // 
            this.txtCompanyNote.Location = new System.Drawing.Point(102, 320);
            this.txtCompanyNote.Name = "txtCompanyNote";
            this.txtCompanyNote.Size = new System.Drawing.Size(260, 30);
            this.txtCompanyNote.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(38, 323);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(48, 22);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "ملاحظات";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(102, 125);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(260, 30);
            this.txtCompanyName.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(12, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 22);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "اسم المؤسسة";
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
            this.pnlOperations.Size = new System.Drawing.Size(575, 40);
            this.pnlOperations.TabIndex = 27;
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
            this.btnESC.Location = new System.Drawing.Point(301, 3);
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
            this.btnSave.Location = new System.Drawing.Point(397, 3);
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
            this.btnNew.Location = new System.Drawing.Point(483, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUploud
            // 
            this.btnUploud.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUploud.FlatAppearance.BorderSize = 0;
            this.btnUploud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnUploud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploud.ForeColor = System.Drawing.Color.Black;
            this.btnUploud.Image = global::appFelxMax.Properties.Resources.EditImageColor;
            this.btnUploud.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUploud.Location = new System.Drawing.Point(368, 266);
            this.btnUploud.Name = "btnUploud";
            this.btnUploud.Size = new System.Drawing.Size(80, 30);
            this.btnUploud.TabIndex = 29;
            this.btnUploud.Text = "تحميل";
            this.btnUploud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUploud.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Image = global::appFelxMax.Properties.Resources.RemoveImageColor;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(454, 266);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 30);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "حذف";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
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
            this.lblHead.Size = new System.Drawing.Size(575, 40);
            this.lblHead.TabIndex = 19;
            this.lblHead.Text = "بيانات المؤسسة";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::appFelxMax.Properties.Resources.FullImageColor;
            this.picLogo.Location = new System.Drawing.Point(368, 86);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(175, 174);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // frmCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 365);
            this.Controls.Add(this.btnUploud);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCompanyNote);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtTaxCard);
            this.Controls.Add(this.txtComRec);
            this.Controls.Add(this.lblTaxCard);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblComRec);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.lblPhone);
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
            this.pnlOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblComRec;
        private System.Windows.Forms.TextBox txtComRec;
        private System.Windows.Forms.Label lblTaxCard;
        private System.Windows.Forms.TextBox txtTaxCard;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtCompanyNote;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUploud;
        private System.Windows.Forms.Button btnRemove;
    }
}