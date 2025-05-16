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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void adduser_but_Click(object sender, EventArgs e)
        {
            string email = email_textbox.Text.Trim();
            string password = password_textbox.Text.Trim();
            string fullname = fullname_textbox.Text.Trim();
            string motto = motto_textbox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(motto))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(password);

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO admin (Email, PasswordHash, FullName, Motto, CreatedAt) 
                             VALUES (@Email, @Password, @FullName, @Motto, NOW())";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@FullName", fullname);
                    cmd.Parameters.AddWithValue("@Motto", motto);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin user added successfully.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add admin user.");
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
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convert to hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
        private void motto_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void suppliername_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
