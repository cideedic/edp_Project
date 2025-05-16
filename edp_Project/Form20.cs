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
    public partial class updatepet : Form
    {
        private int petId;  // PetID passed from Pets form
        private string petName;
        private string breed;
        private decimal price;
        private int supplierId;

        public updatepet(int petId, string name, string species, string breed, int age, decimal price, int supplierId)
        {
            InitializeComponent();
            this.petId = petId;
            name_textbox.Text = name;
            species_textbox.Text = species;
            breed_textbox.Text = breed;
            age_textbox.Text = age.ToString();
            price_textbox.Text = price.ToString();
            supplierid_textbox.Text = supplierId.ToString();
        }

        private void UpdatePetForm_Load(object sender, EventArgs e)
        {
            // Populate the textboxes with the selected pet's details
            name_textbox.Text = petName;
            breed_textbox.Text = breed;
            price_textbox.Text = price.ToString();
            supplierid_textbox.Text = supplierId.ToString();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void addpet_but_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE Pets SET 
                                Name = @name,
                                Species = @species,
                                Breed = @breed,
                                Age = @age,
                                Price = @price,
                                SupplierID = @supplierId
                             WHERE PetID = @petId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name_textbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@species", species_textbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@breed", breed_textbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", int.Parse(age_textbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(price_textbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@supplierId", int.Parse(supplierid_textbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@petId", petId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Pet updated successfully.");
                    else
                        MessageBox.Show("Update failed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.Close();
        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

