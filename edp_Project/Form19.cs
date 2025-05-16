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
    public partial class deletepet : Form
    {
        public deletepet()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void deletePet_but_Click(object sender, EventArgs e)
        {
            string petId = petid_textbox.Text.Trim();

            // Validate if the Pet ID is an integer
            if (int.TryParse(petId, out int parsedPetId))
            {
                // Connection string to MySQL database
                string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

                // Using MySQL connection to interact with the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // Open connection to the database
                        connection.Open();

                        // Prepare the SQL DELETE query to remove the pet by PetID
                        string query = "DELETE FROM Pets WHERE PetID = @petid";

                        // Prepare the command
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@petid", parsedPetId);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pet deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No pet found with the given PetID.");
                        }

                        // Optionally, clear text box or close form
                        petid_textbox.Clear();
                    }
                    catch (Exception ex)
                    {
                        // Display an error message if something goes wrong
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Pet ID.");
            }
        }
    }
}

