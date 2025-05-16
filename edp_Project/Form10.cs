using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace edp_Project
{
    public partial class ChangePassword : Form
    {
        private string _email;
        public ChangePassword(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
    
        }

        private void new_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void con_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void con_but_Click(object sender, EventArgs e)
        {
            string newPassword = new_box.Text.Trim();
            string confirmPassword = con_box.Text.Trim();

            // Check if passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            // Check if the new password is not empty
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            // Optionally, you can add more checks for password strength here, e.g., length, special characters, etc.

            // Hash the new password for storage
            string hashedPassword = HashPassword(newPassword);

            // Update password in the database
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";
            string query = "UPDATE admin SET passwordhash = @PasswordHash WHERE email = @Email";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.Parameters.AddWithValue("@Email", _email);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.");
                            login loginForm = new login();  // Redirect to the login form
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error changing password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();  // Return the hashed password as a string
            }
        }
    }
}
