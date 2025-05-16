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
using Excel = Microsoft.Office.Interop.Excel;


namespace edp_Project
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Customer form2 = new Customer();  
            form2.Show();              
            this.Hide();                
        }

        private void button6_Click(object sender, EventArgs e)
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
        private void LoadCustomerData()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM customers";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    customer_data.DataSource = dataTable;

                    customer_data.AutoGenerateColumns = true;

                    customer_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    customer_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void customer_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM customers WHERE FirstName LIKE @search OR LastName LIKE @search OR Address LIKE @search OR Phone LIKE @search OR Email LIKE @search OR CustomerID LIKE @search";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    customer_data.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void search_but_Click(object sender, EventArgs e)
        {
          
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            addCustomer form2 = new addCustomer();
            form2.Show();
        }

        private void delete_but_Click(object sender, EventArgs e)
        {
            deleteCustomer form2 = new deleteCustomer();
            form2.Show();
        }

        private void update_but_Click(object sender, EventArgs e)
        {
            if (customer_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            // Get selected row
            DataGridViewRow selectedRow = customer_data.SelectedRows[0];

            // Extract data from selected row
            int customerId = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();

            // Pass data to UpdateCustomerForm
            updateCustomer updateForm = new updateCustomer(customerId, firstName, lastName, email, phone, address);
            updateForm.ShowDialog();

            // Reload data after update
            LoadCustomerData();
        }

        private void customer_reportgenerator_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Customer Report";

            // Company Header
            worksheet.Cells[1, 1] = "Pet Store - Customer Report";
            Excel.Range headerRange = worksheet.Range["A1", "F1"]; // Adjust range to match your columns
            headerRange.Merge(); // Merge the cells for a title
            headerRange.Interior.Color = Color.LightGray;
            headerRange.Font.Color = Color.DarkBlue;
            headerRange.Font.Size = 16;
            headerRange.Font.Bold = true;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
            headerRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

            // Sub-header with date (optional)
            worksheet.Cells[2, 1] = $"Report generated on {DateTime.Now}";
            Excel.Range dateRange = worksheet.Range["A2", "F2"];
            dateRange.Merge();
            dateRange.Font.Size = 10;
            dateRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Column Headers
            for (int i = 0; i < customer_data.Columns.Count; i++)
            {
                Excel.Range headerCell = worksheet.Cells[4, i + 1];
                headerCell.Value = customer_data.Columns[i].HeaderText;
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                headerCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                headerCell.Font.Bold = true;
                headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            }

            // Data Rows
            for (int i = 0; i < customer_data.Rows.Count; i++)
            {
                for (int j = 0; j < customer_data.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = customer_data.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();

            // Show Excel
            excelApp.Visible = true;
        }
    }
}
