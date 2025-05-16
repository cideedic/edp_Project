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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace edp_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = username_box.Text.Trim();
            string password = password_box.Text.Trim();

            // Hash the entered password (same way it was stored)
            string hashedPassword = ComputeSha256Hash(password);

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM admin WHERE email = @Email AND passwordhash = @PasswordHash";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login successful!");
                            Customer customerForm = new Customer();
                            customerForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void create_account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount customerForm = new CreateAccount();
            customerForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotpasswordForm = new ForgotPassword();
            forgotpasswordForm.Show();
            this.Hide();
        }
    }
}
