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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Suppliers_Load);
        }

        private void customer_but_Click(object sender, EventArgs e)
        {
            Customer form2 = new Customer();
            form2.Show();
            this.Hide();
        }

        private void orders_but_Click(object sender, EventArgs e)
        {
            Orders form2 = new Orders();
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

        private void supplier_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadSupplierData()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT SupplierID, SupplierName, ContactPerson, Phone, Email, Address FROM suppliers";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    supplier_table.DataSource = table;

                    supplier_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading supplier data: " + ex.Message);
                }
            }
        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            LoadSupplierData();
        }

        private void addsupplier_but_Click(object sender, EventArgs e)
        {
            addSupplier form = new addSupplier();
            form.Show();
        }

        private void deletesupplier_but_Click(object sender, EventArgs e)
        {
            deleteSupplier form = new deleteSupplier();
            form.Show();
        }

        private void updatesupplier_but_Click(object sender, EventArgs e)
        {
            if (supplier_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // Get selected row data
            DataGridViewRow selectedRow = supplier_table.SelectedRows[0];
            int supplierId = Convert.ToInt32(selectedRow.Cells["SupplierID"].Value);
            string supplierName = selectedRow.Cells["SupplierName"].Value.ToString();
            string contactPerson = selectedRow.Cells["ContactPerson"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();

            // Pass data to updateSupplier form
            updateSupplier updateForm = new updateSupplier(
                supplierId,
                supplierName,
                contactPerson,
                phone,
                email,
                address
            );
            updateForm.Show();
        }

        private void supplier_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = supplier_search.Text.Trim();
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT SupplierID, SupplierName, ContactPerson, Phone, Email, Address 
                             FROM suppliers 
                             WHERE 
                                 SupplierName LIKE @search OR 
                                 ContactPerson LIKE @search OR 
                                 Phone LIKE @search OR 
                                 Email LIKE @search OR 
                                 Address LIKE @search";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    supplier_table.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching suppliers: " + ex.Message);
                }
            }
        }

        private void supplier_reportgenerator_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Supplier Report";

            // Title
            worksheet.Cells[1, 1] = "Pet Store - Supplier Report";
            Microsoft.Office.Interop.Excel.Range titleRange = worksheet.Range["A1", "F1"]; // Adjust to fit the number of columns
            titleRange.Merge();
            titleRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
            titleRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            titleRange.Font.Size = 16;
            titleRange.Font.Bold = true;
            titleRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Timestamp
            worksheet.Cells[2, 1] = $"Report generated on {DateTime.Now}";
            Microsoft.Office.Interop.Excel.Range dateRange = worksheet.Range["A2", "F2"];
            dateRange.Merge();
            dateRange.Font.Size = 10;
            dateRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Column Headers
            for (int i = 0; i < supplier_table.Columns.Count; i++)
            {
                var headerCell = worksheet.Cells[4, i + 1];
                headerCell.Value = supplier_table.Columns[i].HeaderText;
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                headerCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                headerCell.Font.Bold = true;
                headerCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }

            // Data Rows
            for (int i = 0; i < supplier_table.Rows.Count; i++)
            {
                for (int j = 0; j < supplier_table.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = supplier_table.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
}
