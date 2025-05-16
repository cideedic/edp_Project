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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace edp_Project
{
    public partial class updateCustomer : Form
    {
        private int customerId;
        public updateCustomer(int id, string fname, string lname, string email, string phone, string address)
        {
            InitializeComponent();
            customerId = id;

            // Assuming you named your text boxes like these:
            textBox_fname.Text = fname;
            textBox_lname.Text = lname;
            textBox_email.Text = email;
            textBox_phone.Text = phone;
            textBox_address.Text = address;
        }

        private void updateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void updateCustomer_but_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"UPDATE Customers SET 
                                FirstName = @FirstName, 
                                LastName = @LastName, 
                                Email = @Email, 
                                Phone = @Phone, 
                                Address = @Address 
                            WHERE CustomerID = @CustomerID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", textBox_fname.Text.Trim());
                    command.Parameters.AddWithValue("@LastName", textBox_lname.Text.Trim());
                    command.Parameters.AddWithValue("@Email", textBox_email.Text.Trim());
                    command.Parameters.AddWithValue("@Phone", textBox_phone.Text.Trim());
                    command.Parameters.AddWithValue("@Address", textBox_address.Text.Trim());
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Customer updated successfully.");
                    else
                        MessageBox.Show("Update failed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.Close();  // Close the update form
        }
    }
}
