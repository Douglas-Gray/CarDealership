using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class DealershipNewCar : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Douglas\source\repos\CarDealership\CarDealership\Cars.mdf; Integrated Security = True";
        public DealershipNewCar()
        {
            InitializeComponent();
        }

        private void DealershipNewCar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string carReg = txtCarReg.Text;
            string carBrand = txtCarBrand.Text;
            string carModel = txtCarModel.Text; 

            SqlConnection connection = new SqlConnection(connectionString);

            string sql = $"INSERT INTO Cars (CarReg, CarBrand, CarModel) VALUES ('{carReg}', '{carBrand}', '{carModel}')";

            if (carReg.Length <= 0 || carReg.Length > 7 || carBrand.Length <= 0 || carModel.Length <= 0)
            {
                MessageBox.Show("Please valid data to input record to database");
                lblRegValidation.Text = "Car registration 1 - 7 Characters";
                lblBrandValidation.Text = "Car brand field required";
                lblModelValidation.Text = "Car model field required";
            }
            else
            {
                try
                {

                    using (connection)
                    {
                        connection.Open();
                        {

                            var cmd = new SqlCommand(sql, connection);

                            cmd.ExecuteNonQuery();

                        }
                        MessageBox.Show("New Record Created");
                        connection.Close();
                    }
                }
                catch (SqlException er)
                {
                    MessageBox.Show("Failed to connect to Database!" + er.ToString());
                    connection.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
