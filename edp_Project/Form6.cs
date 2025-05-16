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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            LoadProducts();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadProducts()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName, Description, Price, StockQuantity, CategoryID FROM Products";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        private void product_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = product_search.Text.Trim();
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT ProductID, ProductName, Description, Price, StockQuantity, CategoryID
                             FROM Products 
                             WHERE 
                                ProductName LIKE @search OR 
                                Description LIKE @search";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching products: " + ex.Message);
                }
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            addProduct form = new addProduct();
            form.Show();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            deleteProd form = new deleteProd();
            form.Show();
        }

        private void productsales_but_Click(object sender, EventArgs e)
        {
            LoadProductSalesData();
        }
        private void LoadProductSalesData()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM productsales";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;  // Replace with your actual DataGridView name
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product sales data: " + ex.Message);
                }
            }
        }

        private void product_reportgenerator_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Product Report";

            // Title
            worksheet.Cells[1, 1] = "Pet Store - Product Report";
            Microsoft.Office.Interop.Excel.Range titleRange = worksheet.Range["A1", "H1"]; // Adjust to fit the number of columns
            titleRange.Merge();
            titleRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
            titleRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            titleRange.Font.Size = 16;
            titleRange.Font.Bold = true;
            titleRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Timestamp
            worksheet.Cells[2, 1] = $"Report generated on {DateTime.Now}";
            Microsoft.Office.Interop.Excel.Range dateRange = worksheet.Range["A2", "H2"];
            dateRange.Merge();
            dateRange.Font.Size = 10;
            dateRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Column Headers
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                var headerCell = worksheet.Cells[4, i + 1];
                headerCell.Value = dataGridView1.Columns[i].HeaderText;
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                headerCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                headerCell.Font.Bold = true;
                headerCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }

            // Data Rows
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
}
