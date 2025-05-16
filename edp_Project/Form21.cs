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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void productname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stock_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryid_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addprod_but_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("AddProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_ProductName", productname_textbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@p_Description", description_textbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@p_Price", decimal.Parse(price_textbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@p_StockQuantity", int.Parse(stock_textbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@p_CategoryID", int.Parse(categoryid_textbox.Text.Trim()));

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Product added successfully.");
                    else
                        MessageBox.Show("Product addition failed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.Close(); // Close the add product form after saving
        }
    }
}
