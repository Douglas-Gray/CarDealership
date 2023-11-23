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
    public partial class DealershipDeleteCar : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Douglas\source\repos\CarDealership\CarDealership\Cars.mdf; Integrated Security = True";
        public DealershipDeleteCar()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string carReg = txtCarReg.Text;

            SqlConnection connection = new SqlConnection(connectionString);

            string sql = $"DELETE FROM Cars WHERE CarReg = '{carReg}'";


            if (carReg.Length <= 0 || carReg.Length > 7)
            {
                MessageBox.Show("Please valid data to input record to database");
                lblRegValidation.Text = "Car registration 1 - 7 Characters";
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
                        MessageBox.Show("Car Deleted");
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
