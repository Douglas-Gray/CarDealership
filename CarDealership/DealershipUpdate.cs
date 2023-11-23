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

                                txtUpdateCarBrand.Text = (string) carReader["CarBrand"];
                                txtUpdateCarModel.Text = (string) carReader["CarModel"];
                                txtUpdateCarReg.Text = (string)carReader["CarReg"]; 

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
    }
}
