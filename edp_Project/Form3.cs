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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            this.Load += Orders_Load;

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

        private void orders_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadOrdersData()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT OrderID, CustomerID, OrderDate, TotalAmount, Status FROM Orders";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    orders_table.DataSource = dataTable;

                    // Optional: Auto-fill and resize columns
                    orders_table.AutoGenerateColumns = true;
                    orders_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    orders_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            LoadOrdersData();
            LoadOrderLogs();
        }

        private void orders_search_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";
            string searchText = orders_search.Text.Trim();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT OrderID, CustomerID, OrderDate, TotalAmount, Status
                FROM Orders
                WHERE 
                    OrderID LIKE @search OR
                    CustomerID LIKE @search OR
                    Status LIKE @search";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    orders_table.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching orders: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getOrder goForm = new getOrder(this); // 'this' is the Orders form
            goForm.Show();
        }
        public DataGridView OrdersTable
        {
            get { return orders_table; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteOrder form3 = new deleteOrder();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (orders_table.SelectedRows.Count > 0)
            {
                int selectedOrderId = Convert.ToInt32(orders_table.SelectedRows[0].Cells["OrderID"].Value);
                updateStatus updateForm = new updateStatus(selectedOrderId);
                updateForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an order first.");
            }
        }

        private void order_logs_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadOrderLogs()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM orderlogs";  // Adjust table/column names if needed
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    order_logs_table.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading logs: " + ex.Message);
                }
            }
        }
        private void updateStatus_Load(object sender, EventArgs e)
        {
            LoadOrderLogs();
        }

        private void delete_logs_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete all order logs?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM OrderLogs";  // Replace with actual table name if different
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show($"{rowsAffected} log(s) deleted.");
                        LoadOrderLogs(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting logs: " + ex.Message);
                    }
                }
            }
        }

        private void orders_reportgenerator_Click(object sender, EventArgs e)
        {
            // Reference Microsoft.Office.Interop.Excel in your project first
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Orders Report";

            // Custom Title Header
            worksheet.Cells[1, 1] = "Pet Store - Orders Report";
            Microsoft.Office.Interop.Excel.Range headerRange = worksheet.Range["A1", "E1"]; // Adjust "E1" if you have more columns
            headerRange.Merge();
            headerRange.Font.Size = 16;
            headerRange.Font.Bold = true;
            headerRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            headerRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Sub-header Date
            worksheet.Cells[2, 1] = $"Report generated on {DateTime.Now.ToString("MMMM dd, yyyy h:mm tt")}";
            Microsoft.Office.Interop.Excel.Range dateRange = worksheet.Range["A2", "E2"];
            dateRange.Merge();
            dateRange.Font.Size = 10;
            dateRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Column Headers (Row 4)
            for (int i = 0; i < orders_table.Columns.Count; i++)
            {
                worksheet.Cells[4, i + 1] = orders_table.Columns[i].HeaderText;
                var columnHeader = worksheet.Cells[4, i + 1];
                columnHeader.Font.Bold = true;
                columnHeader.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                columnHeader.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            }

            // Table Data (starting from Row 5)
            for (int i = 0; i < orders_table.Rows.Count; i++)
            {
                for (int j = 0; j < orders_table.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = orders_table.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
}
