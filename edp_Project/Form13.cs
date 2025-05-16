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
    public partial class deleteCustomer : Form
    {
        public deleteCustomer()
        {
            InitializeComponent();
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void deleteCustomer_but_Click(object sender, EventArgs e)
        {
            // Validate input is a number
            if (!int.TryParse(textBox_customerID.Text.Trim(), out int customerId))
            {
                MessageBox.Show("Please enter a valid numeric Customer ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional: confirm deletion
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            // Connect to database
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully.");
                            this.Close(); // Optional: close the form
                        }
                        else
                        {
                            MessageBox.Show("No customer found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
