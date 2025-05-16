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
    public partial class deleteSupplier : Form
    {
        public deleteSupplier()
        {
            InitializeComponent();
        }

        private void deleteSupplier_but_Click(object sender, EventArgs e)
        {
            string supplierIdText = supplierid_textbox.Text.Trim();

            if (!int.TryParse(supplierIdText, out int supplierId))
            {
                MessageBox.Show("Please enter a valid numeric Supplier ID.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this supplier?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

                using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM suppliers WHERE SupplierID = @id";

                        using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", supplierId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Supplier deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No supplier found with the given ID.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting supplier: " + ex.Message);
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
