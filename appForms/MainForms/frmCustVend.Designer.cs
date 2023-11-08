
namespace appFelxMax.appForms.MainForms
{
    partial class frmCustVend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustVend));
            this.lblHead = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvNameList = new System.Windows.Forms.DataGridView();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlBillTotal = new System.Windows.Forms.Panel();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.pnlDoOperations = new System.Windows.Forms.Panel();
            this.cmbDoOperations = new System.Windows.Forms.ComboBox();
            this.lblDoOperations = new System.Windows.Forms.Label();
            this.pnlOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameList)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBillTotal.SuspendLayout();
            this.pnlDoOperations.SuspendLayout();
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
            this.lblHead.Size = new System.Drawing.Size(1150, 40);
            this.lblHead.TabIndex = 11;
            this.lblHead.Text = "العملاء والموردين ";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOperations.Controls.Add(this.txtSearch);
            this.pnlOperations.Controls.Add(this.lblSearch);
            this.pnlOperations.Controls.Add(this.cmbSort);
            this.pnlOperations.Controls.Add(this.lblFilter);
            this.pnlOperations.Controls.Add(this.btnPrint);
            this.pnlOperations.Controls.Add(this.btnExcel);
            this.pnlOperations.Controls.Add(this.btnNew);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 40);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(1150, 40);
            this.pnlOperations.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(370, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 29);
            this.txtSearch.TabIndex = 18;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSearch.Image = ((System.Drawing.Image)(resources.GetObject("lblSearch.Image")));
            this.lblSearch.Location = new System.Drawing.Point(594, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(30, 30);
            this.lblSearch.TabIndex = 19;
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "أبجدي",
            "الرصيد",
            "مدة التأخير",
            "اخر تعامل"});
            this.cmbSort.Location = new System.Drawing.Point(630, 3);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(158, 37);
            this.cmbSort.TabIndex = 17;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFilter.Image = ((System.Drawing.Image)(resources.GetObject("lblFilter.Image")));
            this.lblFilter.Location = new System.Drawing.Point(794, 3);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(35, 30);
            this.lblFilter.TabIndex = 16;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(835, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(941, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 30);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
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
            this.btnNew.Location = new System.Drawing.Point(1047, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvNameList
            // 
            this.dgvNameList.AllowUserToAddRows = false;
            this.dgvNameList.AllowUserToDeleteRows = false;
            this.dgvNameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNameList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNameList.Location = new System.Drawing.Point(0, 80);
            this.dgvNameList.Name = "dgvNameList";
            this.dgvNameList.ReadOnly = true;
            this.dgvNameList.RowHeadersWidth = 51;
            this.dgvNameList.Size = new System.Drawing.Size(240, 585);
            this.dgvNameList.TabIndex = 13;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvData);
            this.pnlData.Controls.Add(this.pnlFooter);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(240, 80);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(910, 585);
            this.pnlData.TabIndex = 14;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(910, 525);
            this.dgvData.TabIndex = 17;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.Controls.Add(this.button1);
            this.pnlFooter.Controls.Add(this.panel2);
            this.pnlFooter.Controls.Add(this.panel1);
            this.pnlFooter.Controls.Add(this.pnlBillTotal);
            this.pnlFooter.Controls.Add(this.pnlDoOperations);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 525);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(910, 60);
            this.pnlFooter.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "جديد - F1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(33, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 60);
            this.panel2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 36);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "البيان";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(202, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 60);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "البيان";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 36);
            this.textBox1.TabIndex = 0;
            // 
            // pnlBillTotal
            // 
            this.pnlBillTotal.Controls.Add(this.lblValue);
            this.pnlBillTotal.Controls.Add(this.txtValue);
            this.pnlBillTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBillTotal.Location = new System.Drawing.Point(610, 0);
            this.pnlBillTotal.Name = "pnlBillTotal";
            this.pnlBillTotal.Size = new System.Drawing.Size(115, 60);
            this.pnlBillTotal.TabIndex = 6;
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.SeaGreen;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(0, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(115, 27);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "القيمة ";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtValue.Location = new System.Drawing.Point(0, 24);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(115, 36);
            this.txtValue.TabIndex = 0;
            // 
            // pnlDoOperations
            // 
            this.pnlDoOperations.Controls.Add(this.cmbDoOperations);
            this.pnlDoOperations.Controls.Add(this.lblDoOperations);
            this.pnlDoOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDoOperations.Location = new System.Drawing.Point(725, 0);
            this.pnlDoOperations.Name = "pnlDoOperations";
            this.pnlDoOperations.Size = new System.Drawing.Size(185, 60);
            this.pnlDoOperations.TabIndex = 6;
            // 
            // cmbDoOperations
            // 
            this.cmbDoOperations.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbDoOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbDoOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDoOperations.FormattingEnabled = true;
            this.cmbDoOperations.Location = new System.Drawing.Point(0, 23);
            this.cmbDoOperations.Name = "cmbDoOperations";
            this.cmbDoOperations.Size = new System.Drawing.Size(185, 37);
            this.cmbDoOperations.TabIndex = 5;
            // 
            // lblDoOperations
            // 
            this.lblDoOperations.BackColor = System.Drawing.Color.DarkCyan;
            this.lblDoOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDoOperations.ForeColor = System.Drawing.Color.White;
            this.lblDoOperations.Location = new System.Drawing.Point(0, 0);
            this.lblDoOperations.Name = "lblDoOperations";
            this.lblDoOperations.Size = new System.Drawing.Size(185, 27);
            this.lblDoOperations.TabIndex = 0;
            this.lblDoOperations.Text = "العمليات";
            this.lblDoOperations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCustVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 665);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.dgvNameList);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustVend";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العملاء والموردين";
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameList)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBillTotal.ResumeLayout(false);
            this.pnlBillTotal.PerformLayout();
            this.pnlDoOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvNameList;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlBillTotal;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Panel pnlDoOperations;
        private System.Windows.Forms.ComboBox cmbDoOperations;
        private System.Windows.Forms.Label lblDoOperations;
    }
}