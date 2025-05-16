using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace edp_Project
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void motto_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_but_Click(object sender, EventArgs e)
        {
            string email = email_box.Text.Trim();
            string motto = motto_box.Text.Trim();

            // Validate email and motto
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(motto))
            {
                MessageBox.Show("Please enter both email and motto.");
                return;
            }

            // Connection string to connect to MySQL
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            // Query to check if email and motto exist
            string query = "SELECT * FROM admin WHERE email = @Email AND motto = @Motto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Motto", motto);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        // If a record is found
                        if (reader.Read())
                        {
                            // If email and motto are correct, proceed with password reset
                            MessageBox.Show("Motto matched. You can now reset your password.");
                            // Here, you could open a password reset form or perform other actions
                            // For example, let's redirect to a new form to reset the password
                            ChangePassword resetPasswordForm = new ChangePassword(email);
                            resetPasswordForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            // If email or motto is incorrect, show an error message
                            MessageBox.Show("Invalid email or motto. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
