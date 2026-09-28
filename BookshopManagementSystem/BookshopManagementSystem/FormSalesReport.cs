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
    public partial class FormSalesReport : Form
    {
        private DataAccess Da { get; set; }
       
        public FormSalesReport()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
            PopulateGridView();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Invoices where InvoiceId = '" + this.txtId.Text + "';";
            this.PopulateGridView(sql);
        }
        private void PopulateGridView(string sql = "select * from Invoices;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvSalesReport.AutoGenerateColumns = false;
            this.dgvSalesReport.DataSource = ds.Tables[0];
        }
    }
}
