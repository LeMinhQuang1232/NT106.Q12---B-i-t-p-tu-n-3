using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace UserManagementApp
{
    public partial class LoginForm : Form
    {
        private string connectionString =
            "Data Source=DESKTOP-3JVR07D\\SQLEXPRESS;Initial Catalog=UserManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string input = txtEmails.Text.Trim();     
            string password = txtPasswords.Text.Trim();

            if (input == "" || password == "")
            {
                MessageBox.Show("Please fill all!");
                return;
            }

            
            string hashedPassword = Utils.HashPassword(password);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                 
                    string query = "SELECT COUNT(*) FROM Users WHERE (Email=@input OR Username=@input) AND Password=@p";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@input", input);
                    cmd.Parameters.AddWithValue("@p", hashedPassword);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Success Login!");
                        MainForm main = new MainForm(input);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Passwords or Emails!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            
            string username = txtEmails.Text.Trim();
            MainForm main = new MainForm(username);
            main.Show();
            this.Hide();
        }

        private void txtEmails_TextChanged_1(object sender, EventArgs e)
        {
            string username = txtEmails.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                lblEmailStatus.Text = "";
                return;
            }

            if (username.Contains(" "))
            {
                lblEmailStatus.Text = "No space";
                lblEmailStatus.ForeColor = Color.OrangeRed;
                return;
            }

            if (username.Length < 4)
            {
                lblEmailStatus.Text = "Min 4 chars";
                lblEmailStatus.ForeColor = Color.OrangeRed;
                return;
            }

            lblEmailStatus.Text = "Valid";
            lblEmailStatus.ForeColor = Color.LimeGreen;
        }

        private void txtPasswords_TextChanged_1(object sender, EventArgs e)
        {
            string password = txtPasswords.Text;

            if (string.IsNullOrEmpty(password))
            {
                lblPasswordStatus.Text = "";
                return;
            }

            if (password.Length <= 4)
            {
                lblPasswordStatus.Text = "(ಠ_ರೃ)";
                lblPasswordStatus.ForeColor = Color.OrangeRed;
            }
            else
            {
                lblPasswordStatus.Text = "( ͡° ͜ʖ ͡°)";
                lblPasswordStatus.ForeColor = Color.LimeGreen;
            }
        }
    }
}
