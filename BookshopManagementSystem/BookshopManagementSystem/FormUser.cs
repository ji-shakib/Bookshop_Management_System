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
    public partial class FormUser : Form
    {

        public FormLogin Fl { get; set; }
        private DataAccess Da { get; set; }

        public FormAdmin Fad { get; set; }

        public FormUser()
        {
            InitializeComponent();
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);

            this.StartPosition = FormStartPosition.CenterScreen;
            dgvUserInfoDB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();


        }

        public FormUser(string name, FormLogin fl) : this()
        {
            this.lblUserInfo.Text += name.ToUpper();
            this.Fl = fl;

        }
        public FormUser(FormAdmin admin) : this()
        {
            this.Fad = admin;
        }

        private void PopulateGridView(string sql = "select * from Users;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            dgvUserInfoDB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvUserInfoDB.AutoGenerateColumns = false;
            this.dgvUserInfoDB.DataSource = ds.Tables[0];
        }


        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.cmbRole.Text))
                return false;
            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("fields cannot be empty !");
                    return;
                }

                var query = "select * from Users where UserId ='" + this.txtUserId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Users
                                set UserName = '" + this.txtName.Text + @"',
                                Password = '" + this.txtPassword.Text + @"',
                                Role = '" + this.cmbRole.Text + @"'
                                where UserId = '" + this.txtUserId.Text + "'; ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    //insert
                    var sql = "insert into Users values('" + this.txtUserId.Text + "', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.cmbRole.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data added  !");
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
            this.txtUserId.Clear();
            this.txtPassword.Clear();
            this.txtName.Clear();

            this.cmbRole.SelectedIndex = -1;
            this.dgvUserInfoDB.ClearSelection();
            this.txtSearchById.Clear();
            this.txtSearchByName.Clear();

            this.AutoIdGenerate();
        }

        private void AutoIdGenerate()
        {
            var query = "select max(UserId) from Users;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            var newId = "u-" + (++temp).ToString("d3");
            this.txtUserId.Text = newId;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUserInfoDB.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvUserInfoDB.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvUserInfoDB.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + title + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Users where UserId = '" + id + "';";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Fad.Visible = true;
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Users where UserName like '" + this.txtSearchByName.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.dgvUserInfoDB.ClearSelection();
        }

        private void dgvUserInfoDB_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvUserInfoDB.CurrentRow.Cells["UserId"].Value.ToString();
            this.txtName.Text = this.dgvUserInfoDB.CurrentRow.Cells["UserName"].Value.ToString();
            this.txtPassword.Text = this.dgvUserInfoDB.CurrentRow.Cells["Password"].Value.ToString();
            this.cmbRole.Text = this.dgvUserInfoDB.CurrentRow.Cells["Role"].Value.ToString();
        }

        private void txtSearchUserId_Click(object sender, EventArgs e)
        {
            string sql = "select * from Users where UserId = '" + this.txtSearchById.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            //private void dgvUserInfoDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //{

            //}


        }
    }
}
