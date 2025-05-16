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
    public partial class updateStatus : Form
    {
        private int orderIdToUpdate;
        public updateStatus(int orderId)
        {
            InitializeComponent();
            orderIdToUpdate = orderId;
        }

        private void deleteOrder_but_Click(object sender, EventArgs e)
        {
            string selectedStatus = statusCombo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Orders SET Status = @status WHERE OrderID = @orderId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", selectedStatus);
                    cmd.Parameters.AddWithValue("@orderId", orderIdToUpdate);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Order status updated successfully.");
                    else
                        MessageBox.Show("No order was updated. Check Order ID.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order: " + ex.Message);
                }
            }
        }

        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
