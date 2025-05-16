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
    public partial class deleteOrder : Form
    {
        public deleteOrder()
        {
            InitializeComponent();
        }

        private void textBox_customerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_orderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteOrder_but_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";
            string orderIdText = textbox_orderID.Text.Trim();
            string customerIdText = textBox_customerID.Text.Trim();

            if (string.IsNullOrEmpty(orderIdText) && string.IsNullOrEmpty(customerIdText))
            {
                MessageBox.Show("Please enter Order ID, Customer ID, or both.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Build query based on inputs
                    string checkQuery = "";
                    string deleteQuery = "";

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;

                    if (!string.IsNullOrEmpty(orderIdText) && !string.IsNullOrEmpty(customerIdText))
                    {
                        // Validate match before deleting
                        checkQuery = "SELECT COUNT(*) FROM Orders WHERE OrderID = @orderId AND CustomerID = @customerId";
                        deleteQuery = "DELETE FROM Orders WHERE OrderID = @orderId AND CustomerID = @customerId";
                        cmd.Parameters.AddWithValue("@orderId", orderIdText);
                        cmd.Parameters.AddWithValue("@customerId", customerIdText);
                    }
                    else if (!string.IsNullOrEmpty(orderIdText))
                    {
                        checkQuery = "SELECT COUNT(*) FROM Orders WHERE OrderID = @orderId";
                        deleteQuery = "DELETE FROM Orders WHERE OrderID = @orderId";
                        cmd.Parameters.AddWithValue("@orderId", orderIdText);
                    }
                    else
                    {
                        checkQuery = "SELECT COUNT(*) FROM Orders WHERE CustomerID = @customerId";
                        deleteQuery = "DELETE FROM Orders WHERE CustomerID = @customerId";
                        cmd.Parameters.AddWithValue("@customerId", customerIdText);
                    }

                    // Check if order(s) exist
                    cmd.CommandText = checkQuery;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("No matching order(s) found to delete.");
                        return;
                    }

                    // Proceed with deletion
                    cmd.CommandText = deleteQuery;
                    int rowsAffected = cmd.ExecuteNonQuery();

                    MessageBox.Show(rowsAffected + " order(s) deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting order(s): " + ex.Message);
                }
            }
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void deleteOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
