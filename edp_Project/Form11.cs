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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login customerForm = new login();
            customerForm.Show();
            this.Hide();
        }

        private void email_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonenum_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void motto_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_but_Click(object sender, EventArgs e)
        {
            string email = email_box.Text.Trim();
            string fullname = firstname.Text.Trim() + " " + lastname.Text.Trim();
            string password = password_box.Text;
            string mottoValue = motto.Text.Trim();
            string hashedPassword = HashPassword(password);

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO admin (email, fullname, passwordhash, motto) " +
                                   "VALUES (@Email, @FullName, @PasswordHash, @Motto)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@FullName", fullname);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.Parameters.AddWithValue("@Motto", mottoValue);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully!");
                            login loginForm = new login();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account.");
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
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
