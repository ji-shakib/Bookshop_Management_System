namespace BookshopManagementSystem
{
    partial class FormBooks
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
            this.lblBooksInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.lblByingCost = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.lblSearchById = new System.Windows.Forms.Label();
            this.lblSearchByCatagory = new System.Windows.Forms.Label();
            this.txtSearchByCatagory = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBooksInformation
            // 
            this.lblBooksInformation.AutoSize = true;
            this.lblBooksInformation.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksInformation.Location = new System.Drawing.Point(390, 0);
            this.lblBooksInformation.Name = "lblBooksInformation";
            this.lblBooksInformation.Size = new System.Drawing.Size(152, 21);
            this.lblBooksInformation.TabIndex = 0;
            this.lblBooksInformation.Text = "Books information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUnitCost);
            this.panel1.Controls.Add(this.lblByingCost);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.nudQuantity);
            this.panel1.Controls.Add(this.cmbCatagory);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtBookId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCatagory);
            this.panel1.Controls.Add(this.lblAuthor);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblBookId);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 258);
            this.panel1.TabIndex = 1;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(97, 235);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(199, 20);
            this.txtUnitCost.TabIndex = 15;
            // 
            // lblByingCost
            // 
            this.lblByingCost.AutoSize = true;
            this.lblByingCost.Location = new System.Drawing.Point(14, 238);
            this.lblByingCost.Name = "lblByingCost";
            this.lblByingCost.Size = new System.Drawing.Size(62, 13);
            this.lblByingCost.TabIndex = 14;
            this.lblByingCost.Text = "Unit Cost   :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(97, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(199, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(97, 207);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(199, 20);
            this.nudQuantity.TabIndex = 2;
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Items.AddRange(new object[] {
            "Fiction",
            "Biography",
            "Children",
            "Science",
            "History",
            "Fantasy",
            "Programming",
            "Motivation",
            "Poetry",
            "Religious"});
            this.cmbCatagory.Location = new System.Drawing.Point(97, 106);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(199, 21);
            this.cmbCatagory.TabIndex = 13;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(97, 174);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(199, 20);
            this.txtISBN.TabIndex = 12;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(97, 73);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(199, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(97, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(97, 12);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(199, 20);
            this.txtBookId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN          :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price          :";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(12, 109);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(64, 13);
            this.lblCatagory.TabIndex = 3;
            this.lblCatagory.Text = "Catagory    :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 75);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(62, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author       :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title           :";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(12, 15);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(62, 13);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Book Id     :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBooks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 177);
            this.panel2.TabIndex = 2;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.Title,
            this.Author,
            this.Catagory,
            this.UnitCost,
            this.Price,
            this.QuantityInStock,
            this.ISBN});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBooks.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(834, 177);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvBooks.DoubleClick += new System.EventHandler(this.dgvBooks_DoubleClick);
            // 
            // BookId
            // 
            this.BookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.Title.Width = 140;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 140;
            // 
            // Catagory
            // 
            this.Catagory.DataPropertyName = "Catagory";
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            // 
            // UnitCost
            // 
            this.UnitCost.DataPropertyName = "UnitCost";
            this.UnitCost.HeaderText = "Unit cost";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.ReadOnly = true;
            this.UnitCost.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 70;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "QuantityInStock";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            this.QuantityInStock.Width = 90;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(368, 238);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(123, 20);
            this.txtSearchById.TabIndex = 13;
            // 
            // lblSearchById
            // 
            this.lblSearchById.AutoSize = true;
            this.lblSearchById.Location = new System.Drawing.Point(365, 222);
            this.lblSearchById.Name = "lblSearchById";
            this.lblSearchById.Size = new System.Drawing.Size(67, 13);
            this.lblSearchById.TabIndex = 14;
            this.lblSearchById.Text = "Search by Id";
            // 
            // lblSearchByCatagory
            // 
            this.lblSearchByCatagory.AutoSize = true;
            this.lblSearchByCatagory.Location = new System.Drawing.Point(654, 222);
            this.lblSearchByCatagory.Name = "lblSearchByCatagory";
            this.lblSearchByCatagory.Size = new System.Drawing.Size(99, 13);
            this.lblSearchByCatagory.TabIndex = 15;
            this.lblSearchByCatagory.Text = "Search by catagory";
            // 
            // txtSearchByCatagory
            // 
            this.txtSearchByCatagory.Location = new System.Drawing.Point(657, 238);
            this.txtSearchByCatagory.Name = "txtSearchByCatagory";
            this.txtSearchByCatagory.Size = new System.Drawing.Size(174, 20);
            this.txtSearchByCatagory.TabIndex = 16;
            this.txtSearchByCatagory.TextChanged += new System.EventHandler(this.txtSearchByCatagory_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(677, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 38);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(677, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 38);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(677, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 38);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(677, 108);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(122, 39);
            this.btnShowDetails.TabIndex = 21;
            this.btnShowDetails.Text = "SHOW ALL";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(421, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(516, 238);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchByName.TabIndex = 23;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Location = new System.Drawing.Point(513, 222);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(84, 13);
            this.lblSearchByName.TabIndex = 24;
            this.lblSearchByName.Text = "Search by name";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(579, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(67, 24);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.Red;
            this.lblComment.Location = new System.Drawing.Point(365, 156);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(225, 16);
            this.lblComment.TabIndex = 41;
            this.lblComment.Text = "Double click to select a product";
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearchByCatagory);
            this.Controls.Add(this.lblSearchByCatagory);
            this.Controls.Add(this.lblSearchById);
            this.Controls.Add(this.txtSearchById);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBooksInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBooks";
            this.Text = "FormBooks";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooksInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.Label lblSearchByCatagory;
        private System.Windows.Forms.TextBox txtSearchByCatagory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label lblByingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblComment;
    }
}