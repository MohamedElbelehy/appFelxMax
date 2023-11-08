
namespace appFelxMax.appForms.SubForms
{
    partial class frmRadio
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
            this.rdoVend = new System.Windows.Forms.RadioButton();
            this.rdoCust = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoVend
            // 
            this.rdoVend.AutoSize = true;
            this.rdoVend.Location = new System.Drawing.Point(147, 46);
            this.rdoVend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdoVend.Name = "rdoVend";
            this.rdoVend.Size = new System.Drawing.Size(58, 33);
            this.rdoVend.TabIndex = 0;
            this.rdoVend.Text = "مورد";
            this.rdoVend.UseVisualStyleBackColor = true;
            this.rdoVend.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoCust
            // 
            this.rdoCust.AutoSize = true;
            this.rdoCust.Checked = true;
            this.rdoCust.ForeColor = System.Drawing.Color.Green;
            this.rdoCust.Location = new System.Drawing.Point(12, 46);
            this.rdoCust.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdoCust.Name = "rdoCust";
            this.rdoCust.Size = new System.Drawing.Size(63, 33);
            this.rdoCust.TabIndex = 1;
            this.rdoCust.TabStop = true;
            this.rdoCust.Text = "عميل";
            this.rdoCust.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(56, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 49);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "التالي - Entr";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.lblHead.Size = new System.Drawing.Size(217, 41);
            this.lblHead.TabIndex = 15;
            this.lblHead.Text = "تحديد";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 148);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdoCust);
            this.Controls.Add(this.rdoVend);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRadio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديد";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRadio_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoVend;
        private System.Windows.Forms.RadioButton rdoCust;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHead;
    }
}