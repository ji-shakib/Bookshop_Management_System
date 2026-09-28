using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookshopManagementSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtPassword.KeyDown += txtPassword_KeyDown;
            
            txtUserId.KeyDown += txtUserId_KeyDown;
            



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from Users where UserId = '" + this.txtUserId.Text.ToLower() + "' and Password = '" + this.txtPassword.Text + "';";
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-KUTDEJ6\\SQLEXPRESS;Initial Catalog=Bookshop;Persist Security Info=True;User ID=sa;Password=12345");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            try
            {
                if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    throw new Exception("User ID and Password fields cannot be empty.");
                }


                if (ds.Tables[0].Rows.Count == 1)
                {
                    var name = ds.Tables[0].Rows[0][1].ToString();
                    MessageBox.Show("Login succesfull");
                    txtUserId.Text = "";
                    txtPassword.Text = "";
                    this.Hide();

                    if (ds.Tables[0].Rows[0][3].ToString() == "Admin")
                    {
                        new FormAdmin(name, this).Show();
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString().Equals("Salesman"))
                    {
                        new FormSalesman(name, this).Show();
                    }
                }
                
                else
                {
                    MessageBox.Show("Invalid User ID or Password");
                    this.txtPassword.Clear();
                }

                sqlcon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred:\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserId.Text = "";
            txtPassword.Text = "";

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUserId.Focus();
        }

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txtPassword.Focus();  // moves focus to txtPassword on Enter
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();  // triggers login on Enter in password box
                e.Handled = true;
            }
        }
    }
    }