namespace BookshopManagementSystem
{
    partial class FormAdmin
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
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWellcomeAdmin = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalSaleAmount = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvLowStockItems = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTotalSaleOn = new System.Windows.Forms.Panel();
            this.lblTotalSaleOnShow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTotalSaleOn = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStockItems)).BeginInit();
            this.lblTotalSaleOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnSalesReport);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnBooks);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblWellcomeAdmin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 426);
            this.panel1.TabIndex = 3;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesReport.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Location = new System.Drawing.Point(25, 172);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(132, 30);
            this.btnSalesReport.TabIndex = 7;
            this.btnSalesReport.Text = "Sales report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsers.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(25, 126);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(132, 30);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBooks.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Location = new System.Drawing.Point(25, 217);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(133, 30);
            this.btnBooks.TabIndex = 5;
            this.btnBooks.Text = "Books details";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(32, 387);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // lblWellcomeAdmin
            // 
            this.lblWellcomeAdmin.AutoSize = true;
            this.lblWellcomeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWellcomeAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWellcomeAdmin.Location = new System.Drawing.Point(23, 15);
            this.lblWellcomeAdmin.Name = "lblWellcomeAdmin";
            this.lblWellcomeAdmin.Size = new System.Drawing.Size(141, 20);
            this.lblWellcomeAdmin.TabIndex = 3;
            this.lblWellcomeAdmin.Text = "Wellcome Admin";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(437, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(97, 20);
            this.lblDashboard.TabIndex = 4;
            this.lblDashboard.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.lblTotalSaleAmount);
            this.panel2.Location = new System.Drawing.Point(607, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 127);
            this.panel2.TabIndex = 5;
            // 
            // lblTotalSaleAmount
            // 
            this.lblTotalSaleAmount.AutoSize = true;
            this.lblTotalSaleAmount.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaleAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalSaleAmount.Location = new System.Drawing.Point(31, 45);
            this.lblTotalSaleAmount.Name = "lblTotalSaleAmount";
            this.lblTotalSaleAmount.Size = new System.Drawing.Size(63, 31);
            this.lblTotalSaleAmount.TabIndex = 3;
            this.lblTotalSaleAmount.Text = "0.00";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCost.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCost.Location = new System.Drawing.Point(650, 63);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(81, 17);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "Total Sales";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvLowStockItems);
            this.panel4.Location = new System.Drawing.Point(347, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 186);
            this.panel4.TabIndex = 7;
            // 
            // dgvLowStockItems
            // 
            this.dgvLowStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.Title,
            this.QuantityInStock});
            this.dgvLowStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLowStockItems.Location = new System.Drawing.Point(0, 0);
            this.dgvLowStockItems.Name = "dgvLowStockItems";
            this.dgvLowStockItems.ReadOnly = true;
            this.dgvLowStockItems.Size = new System.Drawing.Size(374, 186);
            this.dgvLowStockItems.TabIndex = 1;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "Book Id";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 135;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "QuantityInStock";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(281, 37);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(96, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Total sale on ";
            // 
            // lblTotalSaleOn
            // 
            this.lblTotalSaleOn.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalSaleOn.Controls.Add(this.lblTotalSaleOnShow);
            this.lblTotalSaleOn.Location = new System.Drawing.Point(284, 83);
            this.lblTotalSaleOn.Name = "lblTotalSaleOn";
            this.lblTotalSaleOn.Size = new System.Drawing.Size(174, 127);
            this.lblTotalSaleOn.TabIndex = 8;
            // 
            // lblTotalSaleOnShow
            // 
            this.lblTotalSaleOnShow.AutoSize = true;
            this.lblTotalSaleOnShow.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaleOnShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalSaleOnShow.Location = new System.Drawing.Point(31, 45);
            this.lblTotalSaleOnShow.Name = "lblTotalSaleOnShow";
            this.lblTotalSaleOnShow.Size = new System.Drawing.Size(63, 31);
            this.lblTotalSaleOnShow.TabIndex = 9;
            this.lblTotalSaleOnShow.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(479, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Low stock items";
            // 
            // dtpTotalSaleOn
            // 
            this.dtpTotalSaleOn.Location = new System.Drawing.Point(284, 57);
            this.dtpTotalSaleOn.Name = "dtpTotalSaleOn";
            this.dtpTotalSaleOn.Size = new System.Drawing.Size(200, 20);
            this.dtpTotalSaleOn.TabIndex = 9;
            this.dtpTotalSaleOn.ValueChanged += new System.EventHandler(this.dtpTotalSaleOn_ValueChanged);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.dtpTotalSaleOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalSaleOn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStockItems)).EndInit();
            this.lblTotalSaleOn.ResumeLayout(false);
            this.lblTotalSaleOn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWellcomeAdmin;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel lblTotalSaleOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Label lblTotalSaleAmount;
        private System.Windows.Forms.DataGridView dgvLowStockItems;
        private System.Windows.Forms.Label lblTotalSaleOnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DateTimePicker dtpTotalSaleOn;
    }
}