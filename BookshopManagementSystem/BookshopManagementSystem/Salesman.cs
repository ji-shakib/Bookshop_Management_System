using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookshopManagementSystem
{
    public partial class FormSalesman : Form

    {
        private FormLogin Flo { get; set; }

        private DataAccess Da {  get; set; }
        public FormSalesman()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

            string sqlDelete = "DELETE FROM Products;";
            this.Da.ExecuteDMLQuery(sqlDelete);
            this.PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtNetTotal.Text = "0.00";

        }
        
        public FormSalesman(string name, FormLogin flo) : this()
        {
            this.Flo = flo;

        }

        private void cPopulateGridView(string sql = "select * from Products;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = ds.Tables[0];
        }
        private void PopulateGridView(string sql = "select * from Books;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvShopping.AutoGenerateColumns = false;
            this.dgvShopping.DataSource = ds.Tables[0];
        }

        private void UpdateNetTotal()
        {
            string sql = "SELECT ISNULL(SUM(totalPrice), 0) AS TotalPriceSum FROM Products;";
            var ds = this.Da.ExecuteQuery(sql);
            decimal total = 0m;

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                total = Convert.ToDecimal(ds.Tables[0].Rows[0]["TotalPriceSum"]);
            }

            this.txtNetTotal.Text = total.ToString("F2"); 
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvShopping.CurrentRow == null)
                {
                    MessageBox.Show("Please select a book first.");
                    return;
                }

                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtBookId.Text) ||
                    string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Please Select a book first ! ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stockQuantity = Convert.ToInt32(this.dgvShopping.CurrentRow.Cells[6].Value);
                int selectedQuantity = (int)nudQuantity.Value;

                // Validate quantity
                if (selectedQuantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity !", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (selectedQuantity > stockQuantity)
                {
                    MessageBox.Show("Not enough stock!", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Escape single quotes in title if needed
                string escapedcTitle = txtTitle.Text.Replace("'", "''");
                string escapedcBookId = txtBookId.Text.Replace("'", "''");
                decimal price = Convert.ToDecimal(txtPrice.Text);

                // Prepare SQL query to insert into Products table
                string sql = $"INSERT INTO Products ( cTitle, Price, Quantity,cBookId) " +
                             $"VALUES ('{escapedcTitle}', {price}, {selectedQuantity}, '{escapedcBookId}')";

                int result = this.Da.ExecuteDMLQuery(sql);

                if (result == 1)
                {
                    this.cPopulateGridView();
                    
                    MessageBox.Show("Product added to cart successfully!");
                    UpdateNetTotal();

                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Failed to add product to cart.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void ClearAll()
        {
            this.txtBookId.Clear();
            this.txtTitle.Clear();
            this.nudQuantity.Value = this.nudQuantity.Minimum;
            this.txtSearchById.Clear();
            this.txtSearchByCatagory.Clear();
            this.txtPrice.Clear();
            this.txtSearchByTitle.Clear();

            this.dgvShopping.ClearSelection();
          
        }

        private void dgvShopping_DoubleClick(object sender, EventArgs e)
        {
            this.txtBookId.Text = this.dgvShopping.CurrentRow.Cells[0].Value.ToString();
            this.txtTitle.Text = this.dgvShopping.CurrentRow.Cells[1].Value.ToString();
            this.txtPrice.Text = this.dgvShopping.CurrentRow.Cells[5].Value.ToString();
            
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Books where BookId = '" + this.txtSearchById.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtSearchByTitle_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Books where Title like '" + this.txtSearchByTitle.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void txtSearchByCatagory_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Books where Catagory like '" + this.txtSearchByCatagory.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            this.PopulateGridView();
            this.ClearAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (this.dgvCart.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvCart.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvCart.CurrentRow.Cells[1].Value.ToString();

                // Get totalPrice from the selected row
                decimal totalPriceToRemove = 0m;
                var totalPriceObj = this.dgvCart.CurrentRow.Cells["totalPrice"].Value;  
                if (totalPriceObj != null && decimal.TryParse(totalPriceObj.ToString(), out decimal parsedPrice))
                {
                    totalPriceToRemove = parsedPrice;
                }

                DialogResult res = MessageBox.Show("Are you sure to remove " + title + " from cart ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Products where cBookId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    this.cPopulateGridView();
                    MessageBox.Show(title.ToUpper() + " data has been removed ");

                   
                    if (decimal.TryParse(txtNetTotal.Text, out decimal currentTotal))
                    {
                        decimal newTotal = currentTotal - totalPriceToRemove;
                        if (newTotal < 0) newTotal = 0;  
                        txtNetTotal.Text = newTotal.ToString("F2");
                    }
                }
                else
                {
                    MessageBox.Show("Data hasn't been deleted");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            
            bool hasData = false;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;  
                var cellValue = row.Cells["cBookId"].Value;
                if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    hasData = true;
                    break;
                }
            }

            if (!hasData)
            {
                MessageBox.Show("Nothing to clear. The cart is already empty.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you want to clear the cart?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM Products;";
                this.Da.ExecuteDMLQuery(sqlDelete);
                txtNetTotal.Text = "0.00";
                this.cPopulateGridView();
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            bool hasData = false;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;  
                var cellValue = row.Cells["cBookId"].Value;
                if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    hasData = true;
                    break;
                }
            }

            if (!hasData)
            {
                MessageBox.Show("Please add some books to the cart before confirming the sale.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            
            DialogResult res = MessageBox.Show("Are you sure you want to confirm the sale ?", "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            try
            {
                
                string sqlGetCart = "SELECT cBookId, Quantity FROM Products;";
                var ds = this.Da.ExecuteQuery(sqlGetCart);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string bookId = row["cBookId"].ToString();
                    int quantitySold = Convert.ToInt32(row["Quantity"]);
                    string sqlUpdateStock = $@"
                UPDATE Books
                SET QuantityInStock = QuantityInStock - {quantitySold}
                WHERE BookId = '{bookId}'
                  AND QuantityInStock >= {quantitySold}";
                    int updated = this.Da.ExecuteDMLQuery(sqlUpdateStock);
                    if (updated == 0)
                    {
                        MessageBox.Show($"Warning: Not enough stock for Book ID: {bookId}. Update skipped.");
                     
                    }
                }
                
                string sqlClearCart = "DELETE FROM Products;";
                this.Da.ExecuteDMLQuery(sqlClearCart);
                this.cPopulateGridView();  
                this.PopulateGridView();   
                decimal netTotal = Convert.ToDecimal(txtNetTotal.Text);
                string sqlInsertInvoice = $@"
                INSERT INTO Invoices ( NetTotal, Date)
                VALUES ( {netTotal}, GETDATE())";
                this.Da.ExecuteDMLQuery(sqlInsertInvoice);
                txtNetTotal.Text = "0.00";
                MessageBox.Show("Sale confirmed and stock quantities updated .");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during confirmation: " + ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Hide();  
                if (this.Flo != null)
                {
                    this.Flo.Show();  
                }
                else
                {
                   
                    new FormLogin().Show();
                }
            }
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            FormSalesReport salesReportForm = new FormSalesReport();
            salesReportForm.Show();
        }
    }
}
