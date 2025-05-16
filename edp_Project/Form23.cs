using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edp_Project
{
    public partial class addSupplier : Form
    {
        public addSupplier()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void addsupplier_but_Click(object sender, EventArgs e)
        {
            string supplierName = suppliername_textbox.Text.Trim();
            string contactPerson = contactperson_textbox.Text.Trim();
            string phone = phone_textbox.Text.Trim();
            string email = email_textbox.Text.Trim();
            string address = address_textbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(supplierName) || string.IsNullOrWhiteSpace(contactPerson))
            {
                MessageBox.Show("Please fill in required fields: Supplier Name and Contact Person.");
                return;
            }

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO suppliers (SupplierName, ContactPerson, Phone, Email, Address)
                             VALUES (@name, @contact, @phone, @email, @address)";
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", supplierName);
                        cmd.Parameters.AddWithValue("@contact", contactPerson);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Supplier added successfully.");
                        this.Hide(); // Hide the add form after successful addition
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding supplier: " + ex.Message);
                }
            }
        }
    }
}
