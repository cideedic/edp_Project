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
    public partial class deleteProd : Form
    {
        public deleteProd()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void deleteProd_but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productid_textbox.Text))
            {
                MessageBox.Show("Please enter a Product ID to delete.");
                return;
            }

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("DeleteProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_ProductID", int.Parse(productid_textbox.Text.Trim()));

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Product deleted successfully.");
                    else
                        MessageBox.Show("No product found with the specified ID.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
