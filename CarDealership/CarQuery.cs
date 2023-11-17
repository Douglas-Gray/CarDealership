using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarDealership
{
    public partial class CarQuery : Form
    {

        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Douglas\source\repos\CarDealership\CarDealership\Cars.mdf; Integrated Security = True";
        public CarQuery()
        {
            InitializeComponent();
        }

        private void CarQuery_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carModel = "N/A";
            string carBrand = "N/A";
            string selected = comboBoxCars.Text;
            List<string> cars = new List<string>();

            richTextBoxCars.Clear(); 

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    connection.Open();

                    string sql = $"SELECT CarModel, CarBrand FROM Cars WHERE CarBrand = '{selected}'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader carReader = command.ExecuteReader())
                        {
                            while (carReader.Read())
                            {

                               cars.Add($"{(string)carReader["CarBrand"]} {(string)carReader["CarModel"]}");
                               
                            }
                            carReader.Close();
                        }
                    }
                    connection.Close();
                }
            }
            catch (SqlException er)
            {
                MessageBox.Show("Failed to connect to Database!" + er.ToString());
            }

            foreach(string car in cars)
            {
                richTextBoxCars.AppendText($"{car}\n");  
            }

        }

    }
}
