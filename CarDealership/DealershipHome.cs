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
    public partial class DealershipHome : Form
    {

        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Douglas\source\repos\CarDealership\CarDealership\Cars.mdf; Integrated Security = True";
         
        public DealershipHome()
        {
            InitializeComponent();
        }

        private void DealershipHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carModel = "N/A";
            string carBrand = "N/A";
            string selected = comboBoxBrands.Text;
            List<string> cars = new List<string>();

            SqlConnection connection = new SqlConnection(connectionString);

            listBoxCar.Items.Clear(); 

            try
            {
                using (connection)
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
                connection.Close();
            }

            foreach(string car in cars)
            {
                listBoxCar.Items.Add($"{car}\n");
            }

        }

        private void btnAddNewCars_Click(object sender, EventArgs e)
        {
            DealershipNewCar newForm = new DealershipNewCar();

            Hide();
            newForm.Show(); 
              
        }
    }
}
