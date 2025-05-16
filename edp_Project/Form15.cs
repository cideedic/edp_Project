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
    public partial class getOrder : Form
    {
        private Orders ordersForm;
        public getOrder(Orders form)
        {
            InitializeComponent();
            this.ordersForm = form;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void textbox_cus_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_but_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";
            int customerId;

            if (!int.TryParse(textbox_cus.Text.Trim(), out customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("GetCustomerOrders", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customer_id", customerId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Update the DataGridView in the Orders form
                    ordersForm.OrdersTable.DataSource = table;
                    ordersForm.OrdersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    this.Close(); // Optionally close this form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving orders: " + ex.Message);
                }
            }
        }
    }
}
