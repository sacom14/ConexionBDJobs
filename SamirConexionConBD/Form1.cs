using SamirConexionConBD.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamirConexionConBD
{
    public partial class Form1 : Form
    {

        static string connectionString = "Data Source=79.143.90.12,54321;" +
            "Initial Catalog=SamirEmployees;" +
            "User ID=sa;" +
            "Password=123456789;";
        SqlConnection connection;

        int idJob = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void connectBD(object sender, EventArgs e)
        {
            try

            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                if (!textBoxConnectionStatus.Visible)
                    textBoxConnectionStatus.Visible = true;
                textBoxConnectionStatus.Text = "Connected";
                textBoxConnectionStatus.BackColor = Color.Green;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DesconnectBD(object sender, EventArgs e)
        {
            connection.Close();
            textBoxConnectionStatus.Text = "Desconnected";
            textBoxConnectionStatus.BackColor = Color.Red;
        }

        private void AddNewJob(object sender, EventArgs e)
        {

            if (textBoxJobTitle.Text != "" && decimal.TryParse(textBoxMaxSalary.Text, out decimal minJobSalary) && decimal.TryParse(textBoxMaxSalary.Text, out decimal maxJobSalary))
                InsertNewJob(minJobSalary, maxJobSalary);
        }
        private void InsertNewJob(decimal minJobSalary, decimal maxJobSalary)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string sqlQuery = $"INSERT INTO jobs(job_title, min_salary, max_salary" +
                        $"VALUES ('{textBoxJobTitle.Text}', {minJobSalary}, {maxJobSalary})" +
                        $"SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);

                    object id = cmd.ExecuteScalar();
                    MessageBox.Show(id.ToString());

                    Job newJob = new Job(int.Parse(id.ToString()), textBoxJobTitle.Text, minJobSalary, maxJobSalary);
                    MessageBox.Show("New job add successfully");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

}

