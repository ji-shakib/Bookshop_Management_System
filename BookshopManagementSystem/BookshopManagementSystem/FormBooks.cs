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
    public partial class FormBooks : Form
    {
        private FormAdmin Fa {  get; set; }
        private DataAccess Da { get; set; }

        public FormBooks(FormAdmin Fa)
        {
            InitializeComponent();

                       
            this.Da = new DataAccess();
            this.Fa= Fa;

            this.PopulateGridView();
            this.AutoIdGenerate();
         

        }
        

        private void PopulateGridView(string sql = "select * from Books;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBooks.AutoGenerateColumns = false;
            this.dgvBooks.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


         private void AutoIdGenerate()
        {
            var query = "select max(BookId) from Books;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            var newId = "book-" + (++temp).ToString("d3");
            this.txtBookId.Text = newId;
           
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Books where BookId = '" + this.txtSearchById.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtSearchByCatagory_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Books where Catagory like '" + this.txtSearchByCatagory.Text + "%';";
            this.PopulateGridView(sql);
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtBookId.Text) || string.IsNullOrEmpty(this.txtTitle.Text) ||
                string.IsNullOrEmpty(this.txtAuthor.Text) || string.IsNullOrEmpty(this.cmbCatagory.Text) ||
                string.IsNullOrEmpty(this.txtPrice.Text) || string.IsNullOrEmpty(this.nudQuantity.Text) ||
                string.IsNullOrEmpty(this.txtISBN.Text) || string.IsNullOrEmpty(this.txtUnitCost.Text))
                return false;
            else
                return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("fields cannot be empty !");
                    return;
                }
                // Check if quantity is 0 before saving
                if (this.nudQuantity.Value == 0)
                {
                    MessageBox.Show("Quantity cannot be zero!");
                    this.nudQuantity.Focus();
                    return;
                }

                var query = "select * from Books where BookId ='" + this.txtBookId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Books
                        set Title = '" + this.txtTitle.Text + @"',
                        ISBN = '" + this.txtISBN.Text + @"',
                        Author = '" + this.txtAuthor.Text + @"',
                        Catagory = '" + this.cmbCatagory.Text + @"',
                        UnitCost = '" + this.txtUnitCost.Text + @"',
                        QuantityInStock = '" + this.nudQuantity.Text + @"',
                        Price = '" + this.txtPrice.Text + @"'
                        where BookId = '" + this.txtBookId.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    //insert
                    var sql = "insert into Books values('" + this.txtBookId.Text + "', '" + this.txtTitle.Text + "', '" + this.txtAuthor.Text + "', '" + this.cmbCatagory.Text + "', '" + this.txtUnitCost.Text + "', '" + this.txtPrice.Text + "', '" + this.nudQuantity.Text + "', '" + this.txtISBN.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data added succesfully !");
                    else
                        MessageBox.Show("Data hasn't been added ");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void ClearAll()
        {
            this.txtBookId.Clear();
            this.txtTitle.Clear();
            this.txtISBN.Clear();
            this.nudQuantity.Value = this.nudQuantity.Minimum;
            this.txtAuthor.Clear();
            this.cmbCatagory.SelectedIndex = -1;
            this.txtPrice.Clear();
            this.txtUnitCost.Clear();

            this.txtSearchById.Clear();
            this.txtSearchByCatagory.Clear();
            this.txtSearchByName.Clear();

            this.dgvBooks.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvBooks.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvBooks.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvBooks.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + title + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Books where BookId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " data has been removed ");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dgvBooks_DoubleClick(object sender, EventArgs e)
        {
            this.txtBookId.Text = this.dgvBooks.CurrentRow.Cells[0].Value.ToString();
            this.txtTitle.Text = this.dgvBooks.CurrentRow.Cells[1].Value.ToString();
            this.txtISBN.Text = this.dgvBooks.CurrentRow.Cells["ISBN"].Value.ToString();
            this.txtAuthor.Text = this.dgvBooks.CurrentRow.Cells["Author"].Value.ToString();
            this.nudQuantity.Text = this.dgvBooks.CurrentRow.Cells[5].Value.ToString();
            this.cmbCatagory.Text = this.dgvBooks.CurrentRow.Cells["Catagory"].Value.ToString();
            this.txtPrice.Text = this.dgvBooks.CurrentRow.Cells["Price"].Value.ToString();
            this.txtUnitCost.Text = this.dgvBooks.CurrentRow.Cells[4].Value.ToString();


        }
        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    this.ClearAll();
           
        //}

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {

            var sql = "select * from Books where Title like '" + this.txtSearchByName.Text + "%';";
            this.PopulateGridView(sql);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Fa.Visible = true;


        }

        private void FormBooks_Load(object sender, EventArgs e)
        {

        }

        
    }
}
