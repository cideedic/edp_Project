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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void addCustomer_but_Click(object sender, EventArgs e)
        {
            string fname = textBox_fname.Text.Trim();
            string lname = textBox_lname.Text.Trim();
            string email = textBox_email.Text.Trim();
            string phone = textBox_phone.Text.Trim();
            string address = textBox_address.Text.Trim();

            // Email must contain '@'
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email must contain '@'.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Address: allow only letters, numbers, and spaces
            if (!System.Text.RegularExpressions.Regex.IsMatch(address, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Address can only contain letters, numbers, and spaces.", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("AddCustomer", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@addr", address);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
