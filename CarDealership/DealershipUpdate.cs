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

namespace CarDealership
{
    public partial class DealershipUpdate : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Douglas\source\repos\CarDealership\CarDealership\Cars.mdf; Integrated Security = True";
        public DealershipUpdate()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            string selected = txtCurrentCarReg.Text;

            SqlConnection connection = new SqlConnection(connectionString);

            string sql = $"SELECT CarModel, CarBrand, CarReg FROM Cars WHERE CarReg = '{selected}'";


            try
            {
                using (connection)
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader carReader = command.ExecuteReader())
                        {
                            while (carReader.Read())
                            {
                                string carReg = (string)carReader["CarReg"];
                                carReg = carReg.Trim();

                                txtUpdateCarBrand.Text = (string) carReader["CarBrand"];
                                txtUpdateCarModel.Text = (string) carReader["CarModel"];
                                txtUpdateCarReg.Text = carReg; 
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

        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldCarReg = txtCurrentCarReg.Text; 
            string carReg = txtUpdateCarReg.Text;
            string carBrand = txtUpdateCarBrand.Text;
            string carModel = txtUpdateCarModel.Text;

            SqlConnection connection = new SqlConnection(connectionString);

            string sql = $"UPDATE Cars SET CarBrand = '{carBrand}', CarModel = '{carModel}', CarReg = '{carReg}' WHERE CarReg = '{oldCarReg}'";

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
                        MessageBox.Show("Record Updated");
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
