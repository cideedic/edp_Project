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
    public partial class addpetform : Form
    {
        public addpetform()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void addpet_but_Click(object sender, EventArgs e)
        {
            string petName = name_textbox.Text.Trim();
            string species = species_textbox.Text.Trim();
            string breed = breed_textbox.Text.Trim();
            string age = age_textbox.Text.Trim();
            string gender = gender_combobox.Text.Trim();
            string price = price_textbox.Text.Trim();
            string supplierId = supplierid_textbox.Text.Trim();

            // Validate price to make sure it is a valid decimal
            decimal validPrice;
            if (!decimal.TryParse(price, out validPrice))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Connection string to MySQL database
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            // Using MySQL connection to interact with the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open connection to the database
                    connection.Open();

                    // Prepare the command to call the AddPet stored procedure
                    MySqlCommand cmd = new MySqlCommand("AddPet", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add the parameters that match the stored procedure
                    cmd.Parameters.AddWithValue("@name", petName);
                    cmd.Parameters.AddWithValue("@species", species);
                    cmd.Parameters.AddWithValue("@breed", breed);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@price", validPrice);
                    cmd.Parameters.AddWithValue("@supplierid", supplierId);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Show a success message
                    MessageBox.Show("Pet added successfully!");

                    // Optionally, clear text boxes or close the form
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Display an error message if something goes wrong
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void supplierid_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void price_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gender_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void age_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void breed_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void species_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
