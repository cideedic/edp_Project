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
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
            LoadOrderDetails();
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

        private void orderdetails_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderdetails_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadOrderDetails()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM orderdetails"; 

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    orderdetails_table.DataSource = table;

                    orderdetails_table.AutoGenerateColumns = true;
                    orderdetails_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    orderdetails_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading order details: " + ex.Message);
                }
            }
        }

        private void order_summary_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("GetCustomerOrderSummary", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    orderdetails_table.DataSource = table;

                    // Optional: Adjust DataGridView formatting
                    orderdetails_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    orderdetails_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving customer order summary: " + ex.Message);
                }
            }
        }

        private void orderdetails_reportgenerator_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Order Details Report";

            // Report Title
            worksheet.Cells[1, 1] = "Pet Store - Order Details Report";
            Microsoft.Office.Interop.Excel.Range titleRange = worksheet.Range["A1", "F1"]; // Adjust F1 based on number of columns
            titleRange.Merge();
            titleRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
            titleRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            titleRange.Font.Size = 16;
            titleRange.Font.Bold = true;
            titleRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Sub-header with timestamp
            worksheet.Cells[2, 1] = $"Report generated on {DateTime.Now}";
            Microsoft.Office.Interop.Excel.Range dateRange = worksheet.Range["A2", "F2"];
            dateRange.Merge();
            dateRange.Font.Size = 10;
            dateRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Column Headers
            for (int i = 0; i < orderdetails_table.Columns.Count; i++)
            {
                var headerCell = worksheet.Cells[4, i + 1];
                headerCell.Value = orderdetails_table.Columns[i].HeaderText;
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                headerCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                headerCell.Font.Bold = true;
                headerCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }

            // Data Rows
            for (int i = 0; i < orderdetails_table.Rows.Count; i++)
            {
                for (int j = 0; j < orderdetails_table.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = orderdetails_table.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
}
