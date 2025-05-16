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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();

            LoadAdminData();
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

        private void categories_but_Click(object sender, EventArgs e)
        {
            Categories form2 = new Categories();
            form2.Show();
            this.Hide();
        }

        private void suppliers_but_Click(object sender, EventArgs e)
        {
            Suppliers form2 = new Suppliers();
            form2.Show();
            this.Hide();
        }
        private void LoadAdminData()
        {
            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT AdminID, Email, PasswordHash, FullName, motto, CreatedAt FROM admin";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    admin_table.DataSource = table;

                    admin_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading admin data: " + ex.Message);
                }
            }
        }
        private void addadmin_but_Click(object sender, EventArgs e)
        {
            addUser form2 = new addUser();
            form2.Show();
        }

        private void deleteadmin_but_Click(object sender, EventArgs e)
        {
            deleteUser form2 = new deleteUser();
            form2.Show();
        }

        private void updateadmin_but_Click(object sender, EventArgs e)
        {
            if (admin_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = admin_table.SelectedRows[0];

            int adminId = Convert.ToInt32(selectedRow.Cells["AdminID"].Value);
            string email = selectedRow.Cells["Email"].Value.ToString();
            string fullName = selectedRow.Cells["FullName"].Value.ToString();
            string motto = selectedRow.Cells["motto"].Value?.ToString() ?? "";

            updateUsers updateForm = new updateUsers(adminId, email, fullName, motto);
            updateForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_reportgenerator_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Admin Report";

            // Title
            worksheet.Cells[1, 1] = "Pet Store - Admin Users Report";
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
            for (int i = 0; i < admin_table.Columns.Count; i++)
            {
                var headerCell = worksheet.Cells[4, i + 1];
                headerCell.Value = admin_table.Columns[i].HeaderText;
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                headerCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                headerCell.Font.Bold = true;
                headerCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }

            // Data Rows
            for (int i = 0; i < admin_table.Rows.Count; i++)
            {
                for (int j = 0; j < admin_table.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = admin_table.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
}
