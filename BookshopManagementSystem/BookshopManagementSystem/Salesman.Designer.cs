namespace BookshopManagementSystem
{
    partial class FormSalesman
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
            this.lblSalesmanPanel = new System.Windows.Forms.Label();
            this.pnlSalesmanPanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.pnlShoppingCart = new System.Windows.Forms.Panel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblSearchByTitle = new System.Windows.Forms.Label();
            this.txtSearchByTitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchByCatagory = new System.Windows.Forms.TextBox();
            this.lblSearchByCatagory = new System.Windows.Forms.Label();
            this.lblSearchById = new System.Windows.Forms.Label();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.dgvShopping = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComment = new System.Windows.Forms.Label();
            this.pnlSalesmanPanel.SuspendLayout();
            this.pnlShoppingCart.SuspendLayout();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopping)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesmanPanel
            // 
            this.lblSalesmanPanel.AutoSize = true;
            this.lblSalesmanPanel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesmanPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalesmanPanel.Location = new System.Drawing.Point(21, 8);
            this.lblSalesmanPanel.Name = "lblSalesmanPanel";
            this.lblSalesmanPanel.Size = new System.Drawing.Size(135, 21);
            this.lblSalesmanPanel.TabIndex = 0;
            this.lblSalesmanPanel.Text = "Salesman panel";
            // 
            // pnlSalesmanPanel
            // 
            this.pnlSalesmanPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlSalesmanPanel.Controls.Add(this.btnLogOut);
            this.pnlSalesmanPanel.Controls.Add(this.btnSalesReport);
            this.pnlSalesmanPanel.Controls.Add(this.btnShoppingCart);
            this.pnlSalesmanPanel.Controls.Add(this.lblSalesmanPanel);
            this.pnlSalesmanPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSalesmanPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSalesmanPanel.Name = "pnlSalesmanPanel";
            this.pnlSalesmanPanel.Size = new System.Drawing.Size(179, 441);
            this.pnlSalesmanPanel.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(36, 383);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(110, 29);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Location = new System.Drawing.Point(36, 178);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(110, 39);
            this.btnSalesReport.TabIndex = 3;
            this.btnSalesReport.Text = "Sales report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoppingCart.Location = new System.Drawing.Point(35, 123);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(110, 37);
            this.btnShoppingCart.TabIndex = 1;
            this.btnShoppingCart.Text = "Shopping Cart";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            // 
            // pnlShoppingCart
            // 
            this.pnlShoppingCart.BackColor = System.Drawing.Color.LightBlue;
            this.pnlShoppingCart.Controls.Add(this.lblComment);
            this.pnlShoppingCart.Controls.Add(this.pnlCart);
            this.pnlShoppingCart.Controls.Add(this.panel2);
            this.pnlShoppingCart.Controls.Add(this.panel1);
            this.pnlShoppingCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShoppingCart.Location = new System.Drawing.Point(179, 0);
            this.pnlShoppingCart.Name = "pnlShoppingCart";
            this.pnlShoppingCart.Size = new System.Drawing.Size(655, 441);
            this.pnlShoppingCart.TabIndex = 2;
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlCart.Controls.Add(this.btnRemove);
            this.pnlCart.Controls.Add(this.txtNetTotal);
            this.pnlCart.Controls.Add(this.lblNetTotal);
            this.pnlCart.Controls.Add(this.btnClearCart);
            this.pnlCart.Controls.Add(this.btnConfirm);
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Location = new System.Drawing.Point(304, 3);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(351, 228);
            this.pnlCart.TabIndex = 39;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(182, 199);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 26);
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.Location = new System.Drawing.Point(234, 143);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(117, 31);
            this.txtNetTotal.TabIndex = 42;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetTotal.Location = new System.Drawing.Point(137, 153);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(95, 16);
            this.lblNetTotal.TabIndex = 41;
            this.lblNetTotal.Text = "Net Total  =  ";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.Location = new System.Drawing.Point(268, 199);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(80, 26);
            this.btnClearCart.TabIndex = 39;
            this.btnClearCart.Text = "Clear cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.Location = new System.Drawing.Point(0, 192);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 36);
            this.btnConfirm.TabIndex = 40;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBookId,
            this.cTitle,
            this.cPrice,
            this.Quantity,
            this.TotalPrice});
            this.dgvCart.Location = new System.Drawing.Point(0, 3);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(382, 139);
            this.dgvCart.TabIndex = 0;
            // 
            // cBookId
            // 
            this.cBookId.DataPropertyName = "cBookId";
            this.cBookId.HeaderText = "BookId";
            this.cBookId.Name = "cBookId";
            this.cBookId.ReadOnly = true;
            this.cBookId.Width = 65;
            // 
            // cTitle
            // 
            this.cTitle.DataPropertyName = "cTitle";
            this.cTitle.HeaderText = "Title";
            this.cTitle.Name = "cTitle";
            this.cTitle.ReadOnly = true;
            this.cTitle.Width = 80;
            // 
            // cPrice
            // 
            this.cPrice.DataPropertyName = "cPrice";
            this.cPrice.HeaderText = "Price";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            this.cPrice.Width = 50;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 50;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 65;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.nudQuantity);
            this.panel2.Controls.Add(this.btnAddToCart);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.txtBookId);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblBookId);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 214);
            this.panel2.TabIndex = 1;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(87, 104);
            this.nudQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(138, 20);
            this.nudQuantity.TabIndex = 9;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddToCart.Location = new System.Drawing.Point(87, 172);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(80, 37);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(3, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 36);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(87, 71);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(138, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(87, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(138, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(87, 7);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(138, 20);
            this.txtBookId.TabIndex = 6;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(10, 106);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(12, 10);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(44, 13);
            this.lblBookId.TabIndex = 2;
            this.lblBookId.Text = "Book Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.lblSearchByTitle);
            this.panel1.Controls.Add(this.txtSearchByTitle);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchByCatagory);
            this.panel1.Controls.Add(this.lblSearchByCatagory);
            this.panel1.Controls.Add(this.lblSearchById);
            this.panel1.Controls.Add(this.txtSearchById);
            this.panel1.Controls.Add(this.dgvShopping);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 204);
            this.panel1.TabIndex = 0;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(215, 28);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 23);
            this.btnShowAll.TabIndex = 40;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblSearchByTitle
            // 
            this.lblSearchByTitle.AutoSize = true;
            this.lblSearchByTitle.Location = new System.Drawing.Point(316, 12);
            this.lblSearchByTitle.Name = "lblSearchByTitle";
            this.lblSearchByTitle.Size = new System.Drawing.Size(84, 13);
            this.lblSearchByTitle.TabIndex = 39;
            this.lblSearchByTitle.Text = "Search by name";
            // 
            // txtSearchByTitle
            // 
            this.txtSearchByTitle.Location = new System.Drawing.Point(319, 28);
            this.txtSearchByTitle.Name = "txtSearchByTitle";
            this.txtSearchByTitle.Size = new System.Drawing.Size(139, 20);
            this.txtSearchByTitle.TabIndex = 38;
            this.txtSearchByTitle.TextChanged += new System.EventHandler(this.txtSearchByTitle_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(132, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchByCatagory
            // 
            this.txtSearchByCatagory.Location = new System.Drawing.Point(478, 28);
            this.txtSearchByCatagory.Name = "txtSearchByCatagory";
            this.txtSearchByCatagory.Size = new System.Drawing.Size(174, 20);
            this.txtSearchByCatagory.TabIndex = 36;
            this.txtSearchByCatagory.TextChanged += new System.EventHandler(this.txtSearchByCatagory_TextChanged);
            // 
            // lblSearchByCatagory
            // 
            this.lblSearchByCatagory.AutoSize = true;
            this.lblSearchByCatagory.Location = new System.Drawing.Point(475, 12);
            this.lblSearchByCatagory.Name = "lblSearchByCatagory";
            this.lblSearchByCatagory.Size = new System.Drawing.Size(99, 13);
            this.lblSearchByCatagory.TabIndex = 35;
            this.lblSearchByCatagory.Text = "Search by catagory";
            // 
            // lblSearchById
            // 
            this.lblSearchById.AutoSize = true;
            this.lblSearchById.Location = new System.Drawing.Point(6, 12);
            this.lblSearchById.Name = "lblSearchById";
            this.lblSearchById.Size = new System.Drawing.Size(67, 13);
            this.lblSearchById.TabIndex = 34;
            this.lblSearchById.Text = "Search by Id";
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(3, 28);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(123, 20);
            this.txtSearchById.TabIndex = 33;
            // 
            // dgvShopping
            // 
            this.dgvShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShopping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.Title,
            this.Author,
            this.Catagory,
            this.UnitCost,
            this.Price,
            this.QuantityInStock,
            this.ISBN});
            this.dgvShopping.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShopping.Location = new System.Drawing.Point(0, 54);
            this.dgvShopping.Name = "dgvShopping";
            this.dgvShopping.ReadOnly = true;
            this.dgvShopping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShopping.Size = new System.Drawing.Size(655, 150);
            this.dgvShopping.TabIndex = 32;
            this.dgvShopping.DoubleClick += new System.EventHandler(this.dgvShopping_DoubleClick);
            // 
            // BookId
            // 
            this.BookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Width = 50;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Catagory
            // 
            this.Catagory.DataPropertyName = "Catagory";
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            this.Catagory.Width = 80;
            // 
            // UnitCost
            // 
            this.UnitCost.DataPropertyName = "UnitCost";
            this.UnitCost.HeaderText = "Unit cost";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.ReadOnly = true;
            this.UnitCost.Width = 60;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 60;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "Quantity In Stock";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            this.QuantityInStock.Width = 60;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.Red;
            this.lblComment.Location = new System.Drawing.Point(3, 221);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(225, 16);
            this.lblComment.TabIndex = 40;
            this.lblComment.Text = "Double click to select a product";
            // 
            // FormSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.pnlShoppingCart);
            this.Controls.Add(this.pnlSalesmanPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSalesman";
            this.Text = "Salesman";
            this.pnlSalesmanPanel.ResumeLayout(false);
            this.pnlSalesmanPanel.PerformLayout();
            this.pnlShoppingCart.ResumeLayout(false);
            this.pnlShoppingCart.PerformLayout();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSalesmanPanel;
        private System.Windows.Forms.Panel pnlSalesmanPanel;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Panel pnlShoppingCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchByTitle;
        private System.Windows.Forms.TextBox txtSearchByTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchByCatagory;
        private System.Windows.Forms.Label lblSearchByCatagory;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.DataGridView dgvShopping;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label lblComment;
    }
}