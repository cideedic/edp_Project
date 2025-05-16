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
    public partial class updateUsers : Form
    {
        private int adminId;
        public updateUsers(int adminId, string email, string fullName, string motto)
        {
            InitializeComponent();
            this.adminId = adminId;
            email_textbox.Text = email;
            fullname_textbox.Text = fullName;
            motto_textbox.Text = motto;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void adduser_but_Click(object sender, EventArgs e)
        {
            string email = email_textbox.Text.Trim();
            string fullName = fullname_textbox.Text.Trim();
            string motto = motto_textbox.Text.Trim();
            string password = password_textbox.Text.Trim(); 

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;

                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        string hashedPassword = ComputeSha256Hash(password);
                        query = @"UPDATE admin 
                              SET Email = @Email, FullName = @FullName, Motto = @Motto, PasswordHash = @PasswordHash 
                              WHERE AdminID = @AdminID";
                    }
                    else
                    {
                        query = @"UPDATE admin 
                              SET Email = @Email, FullName = @FullName, Motto = @Motto 
                              WHERE AdminID = @AdminID";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Motto", motto);
                    cmd.Parameters.AddWithValue("@AdminID", adminId);

                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        string hashedPassword = ComputeSha256Hash(password);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    }

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Admin updated successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating admin: " + ex.Message);
                }
            }
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
