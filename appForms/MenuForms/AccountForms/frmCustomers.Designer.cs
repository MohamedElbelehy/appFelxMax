﻿
namespace appFelxMax.appForms.MenuForms.AccountForms
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.dgvNameList = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlOperationDate = new System.Windows.Forms.Panel();
            this.dtpOperationDate = new System.Windows.Forms.DateTimePicker();
            this.lblOperationDate = new System.Windows.Forms.Label();
            this.pnlDescreption = new System.Windows.Forms.Panel();
            this.lblDescreption = new System.Windows.Forms.Label();
            this.txtDescreption = new System.Windows.Forms.TextBox();
            this.pnlValue = new System.Windows.Forms.Panel();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.pnlDoOperations = new System.Windows.Forms.Panel();
            this.cmbDoOperations = new System.Windows.Forms.ComboBox();
            this.lblDoOperations = new System.Windows.Forms.Label();
            this.pnlSafe = new System.Windows.Forms.Panel();
            this.lblSafe = new System.Windows.Forms.Label();
            this.cmbSafe = new System.Windows.Forms.ComboBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.pnlOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameList)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlOperationDate.SuspendLayout();
            this.pnlDescreption.SuspendLayout();
            this.pnlValue.SuspendLayout();
            this.pnlDoOperations.SuspendLayout();
            this.pnlSafe.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.Color.LightGray;
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
            this.pnlOperations.Size = new System.Drawing.Size(1226, 40);
            this.pnlOperations.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(446, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 27);
            this.txtSearch.TabIndex = 18;
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "أبجدي",
            "الرصيد",
            "مدة التأخير",
            "اخر تعامل"});
            this.cmbSort.Location = new System.Drawing.Point(706, 3);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(158, 30);
            this.cmbSort.TabIndex = 17;
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
            this.dgvNameList.Size = new System.Drawing.Size(315, 784);
            this.dgvNameList.TabIndex = 14;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.pnlSafe);
            this.pnlFooter.Controls.Add(this.pnlOperationDate);
            this.pnlFooter.Controls.Add(this.pnlDescreption);
            this.pnlFooter.Controls.Add(this.pnlValue);
            this.pnlFooter.Controls.Add(this.pnlDoOperations);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(315, 804);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(911, 60);
            this.pnlFooter.TabIndex = 17;
            // 
            // pnlOperationDate
            // 
            this.pnlOperationDate.Controls.Add(this.dtpOperationDate);
            this.pnlOperationDate.Controls.Add(this.lblOperationDate);
            this.pnlOperationDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOperationDate.Location = new System.Drawing.Point(245, 0);
            this.pnlOperationDate.Name = "pnlOperationDate";
            this.pnlOperationDate.Size = new System.Drawing.Size(109, 60);
            this.pnlOperationDate.TabIndex = 8;
            // 
            // dtpOperationDate
            // 
            this.dtpOperationDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpOperationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOperationDate.Location = new System.Drawing.Point(0, 30);
            this.dtpOperationDate.Name = "dtpOperationDate";
            this.dtpOperationDate.RightToLeftLayout = true;
            this.dtpOperationDate.Size = new System.Drawing.Size(109, 30);
            this.dtpOperationDate.TabIndex = 3;
            // 
            // lblOperationDate
            // 
            this.lblOperationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblOperationDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOperationDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOperationDate.ForeColor = System.Drawing.Color.White;
            this.lblOperationDate.Location = new System.Drawing.Point(0, 0);
            this.lblOperationDate.Name = "lblOperationDate";
            this.lblOperationDate.Size = new System.Drawing.Size(109, 27);
            this.lblOperationDate.TabIndex = 2;
            this.lblOperationDate.Text = "التاريخ";
            this.lblOperationDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDescreption
            // 
            this.pnlDescreption.Controls.Add(this.lblDescreption);
            this.pnlDescreption.Controls.Add(this.txtDescreption);
            this.pnlDescreption.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDescreption.Location = new System.Drawing.Point(354, 0);
            this.pnlDescreption.Name = "pnlDescreption";
            this.pnlDescreption.Size = new System.Drawing.Size(308, 60);
            this.pnlDescreption.TabIndex = 7;
            // 
            // lblDescreption
            // 
            this.lblDescreption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblDescreption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescreption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescreption.ForeColor = System.Drawing.Color.White;
            this.lblDescreption.Location = new System.Drawing.Point(0, 0);
            this.lblDescreption.Name = "lblDescreption";
            this.lblDescreption.Size = new System.Drawing.Size(308, 27);
            this.lblDescreption.TabIndex = 2;
            this.lblDescreption.Text = "البيان";
            this.lblDescreption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescreption
            // 
            this.txtDescreption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescreption.Location = new System.Drawing.Point(0, 30);
            this.txtDescreption.Name = "txtDescreption";
            this.txtDescreption.Size = new System.Drawing.Size(308, 30);
            this.txtDescreption.TabIndex = 0;
            // 
            // pnlValue
            // 
            this.pnlValue.Controls.Add(this.lblValue);
            this.pnlValue.Controls.Add(this.txtValue);
            this.pnlValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlValue.Location = new System.Drawing.Point(662, 0);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Size = new System.Drawing.Size(115, 60);
            this.pnlValue.TabIndex = 6;
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
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
            this.txtValue.Location = new System.Drawing.Point(0, 30);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(115, 30);
            this.txtValue.TabIndex = 0;
            // 
            // pnlDoOperations
            // 
            this.pnlDoOperations.Controls.Add(this.cmbDoOperations);
            this.pnlDoOperations.Controls.Add(this.lblDoOperations);
            this.pnlDoOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDoOperations.Location = new System.Drawing.Point(777, 0);
            this.pnlDoOperations.Name = "pnlDoOperations";
            this.pnlDoOperations.Size = new System.Drawing.Size(134, 60);
            this.pnlDoOperations.TabIndex = 6;
            // 
            // cmbDoOperations
            // 
            this.cmbDoOperations.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbDoOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbDoOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDoOperations.FormattingEnabled = true;
            this.cmbDoOperations.Location = new System.Drawing.Point(0, 30);
            this.cmbDoOperations.Name = "cmbDoOperations";
            this.cmbDoOperations.Size = new System.Drawing.Size(134, 30);
            this.cmbDoOperations.TabIndex = 5;
            // 
            // lblDoOperations
            // 
            this.lblDoOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblDoOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDoOperations.ForeColor = System.Drawing.Color.White;
            this.lblDoOperations.Location = new System.Drawing.Point(0, 0);
            this.lblDoOperations.Name = "lblDoOperations";
            this.lblDoOperations.Size = new System.Drawing.Size(134, 27);
            this.lblDoOperations.TabIndex = 0;
            this.lblDoOperations.Text = "العمليات";
            this.lblDoOperations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSafe
            // 
            this.pnlSafe.Controls.Add(this.cmbSafe);
            this.pnlSafe.Controls.Add(this.lblSafe);
            this.pnlSafe.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSafe.Location = new System.Drawing.Point(91, 0);
            this.pnlSafe.Name = "pnlSafe";
            this.pnlSafe.Size = new System.Drawing.Size(154, 60);
            this.pnlSafe.TabIndex = 9;
            // 
            // lblSafe
            // 
            this.lblSafe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblSafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSafe.ForeColor = System.Drawing.Color.White;
            this.lblSafe.Location = new System.Drawing.Point(0, 0);
            this.lblSafe.Name = "lblSafe";
            this.lblSafe.Size = new System.Drawing.Size(154, 27);
            this.lblSafe.TabIndex = 3;
            this.lblSafe.Text = "الخزنة";
            this.lblSafe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbSafe
            // 
            this.cmbSafe.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbSafe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbSafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSafe.FormattingEnabled = true;
            this.cmbSafe.Location = new System.Drawing.Point(0, 30);
            this.cmbSafe.Name = "cmbSafe";
            this.cmbSafe.Size = new System.Drawing.Size(154, 30);
            this.cmbSafe.TabIndex = 6;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvData);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(315, 80);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(911, 724);
            this.pnlData.TabIndex = 18;
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
            this.dgvData.Size = new System.Drawing.Size(911, 724);
            this.dgvData.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::appFelxMax.Properties.Resources.DoneW;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 60);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "حفظ - F2";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSearch.Image = global::appFelxMax.Properties.Resources.SearchB;
            this.lblSearch.Location = new System.Drawing.Point(670, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(30, 30);
            this.lblSearch.TabIndex = 19;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFilter.Image = global::appFelxMax.Properties.Resources.FilterColor;
            this.lblFilter.Location = new System.Drawing.Point(870, 3);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(35, 30);
            this.lblFilter.TabIndex = 16;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = global::appFelxMax.Properties.Resources.PrinterColor;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(911, 3);
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
            this.btnExcel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1017, 3);
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
            this.btnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = global::appFelxMax.Properties.Resources.AddColor;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(1123, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "جديد - F1";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHead.Image = global::appFelxMax.Properties.Resources.UserGroup1Color;
            this.lblHead.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Padding = new System.Windows.Forms.Padding(1100, 0, 0, 0);
            this.lblHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHead.Size = new System.Drawing.Size(1226, 40);
            this.lblHead.TabIndex = 12;
            this.lblHead.Text = "العملاء ";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 864);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.dgvNameList);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Tanseek Modern Pro Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmCustomers";
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameList)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlOperationDate.ResumeLayout(false);
            this.pnlDescreption.ResumeLayout(false);
            this.pnlDescreption.PerformLayout();
            this.pnlValue.ResumeLayout(false);
            this.pnlValue.PerformLayout();
            this.pnlDoOperations.ResumeLayout(false);
            this.pnlSafe.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvNameList;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlSafe;
        private System.Windows.Forms.ComboBox cmbSafe;
        private System.Windows.Forms.Label lblSafe;
        private System.Windows.Forms.Panel pnlOperationDate;
        private System.Windows.Forms.DateTimePicker dtpOperationDate;
        private System.Windows.Forms.Label lblOperationDate;
        private System.Windows.Forms.Panel pnlDescreption;
        private System.Windows.Forms.Label lblDescreption;
        private System.Windows.Forms.TextBox txtDescreption;
        private System.Windows.Forms.Panel pnlValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Panel pnlDoOperations;
        private System.Windows.Forms.ComboBox cmbDoOperations;
        private System.Windows.Forms.Label lblDoOperations;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvData;
    }
}