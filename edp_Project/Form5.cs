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
    public partial class Pets : Form
    {
        public Pets()
        {
            InitializeComponent();
            this.Load += Pets_Load;
            LoadPetLogs();
        }
        private void Pets_Load(object sender, EventArgs e)
        {
            LoadPetsData();
        }

        private void orders_but_Click(object sender, EventArgs e)
        {
            Orders form2 = new Orders();
            form2.Show();
            this.Hide();
        }

        private void customer_but_Click(object sender, EventArgs e)
        {
            Customer form2 = new Customer();
            form2.Show();
            this.Hide();
        }

        private void orderdetails_but_Click(object sender, EventArgs e)
        {
            OrderDetails form2 = new OrderDetails();
            form2.Show();
            this.Hide();
        }

        private void pets_but_Click(object sender, EventArgs e)
        {
            Pets form2 = new Pets();
            form2.Show();
            this.Hide();
        }

        private void products_but_Click(object sender, EventArgs e)
        {
            Products form2 = new Products();
            form2.Show();
            this.Hide();
        }

        private void suppliers_but_Click(object sender, EventArgs e)
        {
            Suppliers form2 = new Suppliers();
            form2.Show();
            this.Hide();
        }

        private void categories_but_Click(object sender, EventArgs e)
        {
            Categories form2 = new Categories();
            form2.Show();
            this.Hide();
        }

        private void pet_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = pet_search.Text.Trim();
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT PetID, Name, Species, Breed, Age, Price, ArrivalDate, Status, SupplierID
                             FROM pets 
                             WHERE 
                                Name LIKE @search OR 
                                Species LIKE @search OR 
                                Breed LIKE @search OR 
                                Gender LIKE @search";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    pet_table.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching pets: " + ex.Message);
                }
            }
        }
        private void LoadPetLogs()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM PetLogs ORDER BY LogID ASC"; // adjust fields as needed
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    pet_logs.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading logs: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPetsData()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT PetID, Name, Species, Breed, Age, Price, ArrivalDate, Status, SupplierID FROM pets;";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    pet_table.DataSource = table;

                    pet_table.AutoGenerateColumns = true;
                    pet_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    pet_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading pets: " + ex.Message);
                }
            }
        }

        private void addpet_but_Click(object sender, EventArgs e)
        {
            addpetform form = new addpetform();
            form.Show();
        }
     
        private void deletepet_but_Click(object sender, EventArgs e)
        {
            deletepet form = new deletepet();
            form.Show();
        }

        private void updatepet_but_Click(object sender, EventArgs e)
        {
            if (pet_table.SelectedRows.Count > 0)
            {
                // Get values from the selected row
                int petId = Convert.ToInt32(pet_table.SelectedRows[0].Cells["PetID"].Value);
                string name = pet_table.SelectedRows[0].Cells["Name"].Value.ToString();
                string species = pet_table.SelectedRows[0].Cells["Species"].Value.ToString();
                string breed = pet_table.SelectedRows[0].Cells["Breed"].Value.ToString();
                int age = Convert.ToInt32(pet_table.SelectedRows[0].Cells["Age"].Value);
                decimal price = Convert.ToDecimal(pet_table.SelectedRows[0].Cells["Price"].Value);
                int supplierId = Convert.ToInt32(pet_table.SelectedRows[0].Cells["SupplierID"].Value);

                // Open the updatepet form and pass selected values
                updatepet updateForm = new updatepet(petId, name, species, breed, age, price, supplierId);
                updateForm.ShowDialog(); // or .Show() if you prefer
            }
            else
            {
                MessageBox.Show("Please select a pet to update.");
            }
        }

        private void Pets_Load_1(object sender, EventArgs e)
        {

        }

        private void pet_logs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete all pet logs?",
                              "Confirm Delete",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM PetLogs";
                        MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("All pet logs deleted.");
                        LoadPetLogs(); // Refresh table
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting logs: " + ex.Message);
                    }
                }
            }
        }

        private void pet_reportgenerator_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Pet Report";

            // Title
            worksheet.Cells[1, 1] = "Pet Store - Pet Inventory Report";
            Microsoft.Office.Interop.Excel.Range titleRange = worksheet.Range["A1", "I1"]; // A to I for 9 columns
            titleRange.Merge();
            titleRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
            titleRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            titleRange.Font.Size = 16;
            titleRange.Font.Bold = true;
            titleRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Timestamp
            worksheet.Cells[2, 1] = $"Report generated on {DateTime.Now}";
            Microsoft.Office.Interop.Excel.Range dateRange = worksheet.Range["A2", "I2"];
            dateRange.Merge();
            dateRange.Font.Size = 10;
            dateRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Column Headers
            for (int i = 0; i < pet_table.Columns.Count; i++)
            {
                var headerCell = worksheet.Cells[4, i + 1];
                headerCell.Value = pet_table.Columns[i].HeaderText;
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                headerCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                headerCell.Font.Bold = true;
                headerCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }

            // Data Rows
            for (int i = 0; i < pet_table.Rows.Count; i++)
            {
                for (int j = 0; j < pet_table.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = pet_table.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
}
