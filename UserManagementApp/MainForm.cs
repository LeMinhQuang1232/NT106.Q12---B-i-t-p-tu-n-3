using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace UserManagementApp
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-3JVR07D\\SQLEXPRESS;Initial Catalog=UserManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private string currentUsername;

        public MainForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Username, Email, Password FROM Users WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", currentUsername);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text = reader["Username"].ToString();
                            txtEmails.Text = reader["Email"].ToString();
                            txtPasswords.Text = reader["Password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin người dùng!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
