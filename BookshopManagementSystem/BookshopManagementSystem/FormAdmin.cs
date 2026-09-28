using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookshopManagementSystem
{
    public partial class FormAdmin : Form
    {
        //public FormAdmin()
        //{
        //    InitializeComponent();
        //}
        private FormUser Fu {  get; set; }
        private FormBooks Fb {  get; set; }
        private FormLogin Fl { get; set; }

        public FormAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UpdateTotalSalesAmount();
            PopulateLowStockItems();
            UpdateSalesAmountByDate(DateTime.Today);
            dtpTotalSaleOn.ValueChanged += dtpTotalSaleOn_ValueChanged;

        }

        public FormAdmin(string name, FormLogin fl) : this()
        {
            //this.lblWellcomeAdmin.Text += name.ToUpper();
            this.Fl = fl;
            this.Fb = new FormBooks(this);
            this.Fu=new FormUser(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Logged out from the system");
            this.Fl.Visible = true;
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closing the application");
            Application.Exit();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Visible = false;
                MessageBox.Show("Logged out from the system");
                this.Fl.Visible = true;
            }

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Fb.Visible = true;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Fu.Visible = true;


        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            FormSalesReport salesReportForm = new FormSalesReport();
            salesReportForm.Show();
        }
        private void UpdateTotalSalesAmount()
        {
            try
            {
                string sql = "SELECT ISNULL(SUM(NetTotal), 0) AS NetTotal FROM Invoices;";
                var ds = new DataAccess().ExecuteQuery(sql);
                decimal totalSales = 0m;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    totalSales = Convert.ToDecimal(ds.Tables[0].Rows[0]["NetTotal"]);
                lblTotalSaleAmount.Text = totalSales.ToString("C2"); // currency format
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total sales: " + ex.Message);
                lblTotalSaleAmount.Text = "N/A";
            }
        }
        private void PopulateLowStockItems()
        {
            try
            {
                string sql = "SELECT * FROM Books WHERE QuantityInStock < 10;";
                var ds = new DataAccess().ExecuteQuery(sql);

                dgvLowStockItems.AutoGenerateColumns = false; // If columns are predefined; set true to auto-generate
                dgvLowStockItems.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading low stock items: " + ex.Message);
            }
        }

        private void dtpTotalSaleOn_ValueChanged(object sender, EventArgs e)
        {
            UpdateSalesAmountByDate(dtpTotalSaleOn.Value.Date);

        }
        private void UpdateSalesAmountByDate(DateTime selectedDate)
        {
            try
            {
                string sql = @"SELECT ISNULL(SUM(NetTotal), 0) AS NetTotalByDate FROM Invoices WHERE CAST(Date AS DATE) = @SelectedDate";

                var param = new SqlParameter("@SelectedDate", SqlDbType.Date);
                param.Value = selectedDate;

                var ds = new DataAccess().ExecuteQueryWithParameter(sql, param);

                decimal totalSales = 0m;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    totalSales = Convert.ToDecimal(ds.Tables[0].Rows[0]["NetTotalByDate"]);

                lblTotalSaleOnShow.Text = totalSales.ToString("C2"); // show on your label
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total sales: " + ex.Message);
                lblTotalSaleOnShow.Text = "N/A";
            }
        }



    }
}
