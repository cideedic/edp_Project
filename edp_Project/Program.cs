using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace edp_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());

            string connectionString = "server=localhost;user=root;password=iluvflyff133;database=petstoredb;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    Console.WriteLine("✅ Database Connected Successfully!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                }
            }
        }
    }
}
