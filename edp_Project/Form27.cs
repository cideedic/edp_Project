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
    public partial class deleteUser : Form
    {
        public deleteUser()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void deleteUser_but_Click(object sender, EventArgs e)
        {
            string adminId = userid_textbox.Text.Trim();

            if (string.IsNullOrEmpty(adminId))
            {
                MessageBox.Show("Please enter the Admin ID to delete.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this admin user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM admin WHERE AdminID = @AdminID";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@AdminID", adminId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Admin user deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Admin user not found or could not be deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
