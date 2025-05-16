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
    public partial class updateSupplier : Form
    {
        private int supplierId;
        public updateSupplier(int id, string name, string contact, string phone, string email, string address)
        {
            InitializeComponent();

            supplierId = id;
            suppliername_textbox.Text = name;
            contactperson_textbox.Text = contact;
            phone_textbox.Text = phone;
            email_textbox.Text = email;
            address_textbox.Text = address;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void updatesupplier_but_Click(object sender, EventArgs e)
        {
            string supplierName = suppliername_textbox.Text.Trim();
            string contactPerson = contactperson_textbox.Text.Trim();
            string phone = phone_textbox.Text.Trim();
            string email = email_textbox.Text.Trim();
            string address = address_textbox.Text.Trim();

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE suppliers 
                             SET SupplierName = @name,
                                 ContactPerson = @contact,
                                 Phone = @phone,
                                 Email = @email,
                                 Address = @address
                             WHERE SupplierID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", supplierName);
                    cmd.Parameters.AddWithValue("@contact", contactPerson);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@id", supplierId);  // Remember: supplierId is set from the constructor

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Supplier updated successfully.");
                        this.Close(); // Close update form after successful update
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating supplier: " + ex.Message);
                }
            }
        }
    }
}
