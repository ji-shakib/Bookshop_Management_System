namespace BookshopManagementSystem
{
    partial class FormSalesReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSalesReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 168);
            this.panel1.TabIndex = 0;
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceId,
            this.NetTotal,
            this.Date});
            this.dgvSalesReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSalesReport.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.ReadOnly = true;
            this.dgvSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesReport.Size = new System.Drawing.Size(384, 168);
            this.dgvSalesReport.TabIndex = 0;
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(12, 9);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(104, 21);
            this.lblSalesReport.TabIndex = 1;
            this.lblSalesReport.Text = "Sales report";
            // 
            // InvoiceId
            // 
            this.InvoiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "Invoice ID";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.ReadOnly = true;
            // 
            // NetTotal
            // 
            this.NetTotal.DataPropertyName = "NetTotal";
            this.NetTotal.HeaderText = "Net total";
            this.NetTotal.Name = "NetTotal";
            this.NetTotal.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 145;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(315, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(209, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // lblInvoiceId
            // 
            this.lblInvoiceId.AutoSize = true;
            this.lblInvoiceId.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceId.ForeColor = System.Drawing.Color.Black;
            this.lblInvoiceId.Location = new System.Drawing.Point(206, 48);
            this.lblInvoiceId.Name = "lblInvoiceId";
            this.lblInvoiceId.Size = new System.Drawing.Size(56, 14);
            this.lblInvoiceId.TabIndex = 4;
            this.lblInvoiceId.Text = "Invoice ID";
            // 
            // FormSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblInvoiceId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSalesReport);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSalesReport";
            this.Text = "FormSalesReport";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblInvoiceId;
    }
}