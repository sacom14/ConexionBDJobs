using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamirConexionConBD
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string connectionString = "Data Source=79.143.90.12,54321;" +
                "Initial Catalog=SamirEmployees;" +
                "User ID=sa;" +
                "Password=123456789;";

            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            } //en este punto la conexión se cerrará automáticamente por usar el using, sinó hay que usar el connection.close();


        }
    }
}
