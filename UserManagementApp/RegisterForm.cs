using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace UserManagementApp
{
    public partial class RegisterForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-3JVR07D\\SQLEXPRESS;Initial Catalog=UserManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                lblUserStatus.Text = "";
                return;
            }

            if (username.Contains(" "))
            {
                lblUserStatus.Text = "No space";
                lblUserStatus.ForeColor = Color.OrangeRed;
                return;
            }

            if (username.Length < 4)
            {
                lblUserStatus.Text = "Min 4 chars";
                lblUserStatus.ForeColor = Color.OrangeRed;
                return;
            }

            lblUserStatus.Text = "Valid";
            lblUserStatus.ForeColor = Color.LimeGreen;
        }

        private void txtEmails_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmails.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                lblEmailStatus.Text = "";
                return;
            }

            if (IsValidEmail(email))
            {
                lblEmailStatus.Text = "Valid";
                lblEmailStatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblEmailStatus.Text = "Incorect Email Form";
                lblEmailStatus.ForeColor = Color.OrangeRed;
            }
        }

        private void txtPasswords_TextChanged(object sender, EventArgs e)
        {
            string password = txtPasswords.Text;

            if (string.IsNullOrEmpty(password))
            {
                lblPasswordStatus.Text = "";
                return;
            }

            int strength = GetPasswordStrength(password);

            if (strength <= 2)
            {
                lblPasswordStatus.Text = "Weak";
                lblPasswordStatus.ForeColor = Color.Red;
            }
            else if (strength == 3 || strength == 4)
            {
                lblPasswordStatus.Text = "Decent";
                lblPasswordStatus.ForeColor = Color.Orange;
            }
            else
            {
                lblPasswordStatus.Text = "Strong";
                lblPasswordStatus.ForeColor = Color.LimeGreen;
            }
        }

        private void txtConfirmPasswords_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPasswords.Text))
            {
                lblConfirmStatus.Text = "";
                return;
            }

            if (txtConfirmPasswords.Text == txtPasswords.Text)
            {
                lblConfirmStatus.Text = "Correct";
                lblConfirmStatus.ForeColor = Color.Green;
            }
            else
            {
                lblConfirmStatus.Text = "Incorrect";
                lblConfirmStatus.ForeColor = Color.Red;
            }
        }

       
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmails.Text.Trim();
            string password = txtPasswords.Text.Trim();
            string confirm = txtConfirmPasswords.Text.Trim();

            if (username == "" || email == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Please fill all the box!");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Doesnt match the confirm passwords!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@u OR Email=@e", conn);
                checkCmd.Parameters.AddWithValue("@u", username);
                checkCmd.Parameters.AddWithValue("@e", email);

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Already existed!");
                    return;
                }

                
                string hashedPassword = Utils.HashPassword(password);

               
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO Users (Username, Email, Password) VALUES (@u, @e, @p)", conn);
                insertCmd.Parameters.AddWithValue("@u", username);
                insertCmd.Parameters.AddWithValue("@e", email);
                insertCmd.Parameters.AddWithValue("@p", hashedPassword);

                int rows = insertCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Success Register!");
                    this.Hide();
                    new LoginForm().Show();
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
        }

        

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private int GetPasswordStrength(string password)
        {
            int score = 0;
            if (password.Length >= 6) score++;
            if (Regex.IsMatch(password, "[a-z]")) score++;
            if (Regex.IsMatch(password, "[A-Z]")) score++;
            if (Regex.IsMatch(password, "[0-9]")) score++;
            if (Regex.IsMatch(password, "[^a-zA-Z0-9]")) score++;
            return score;
        }
    }
}
