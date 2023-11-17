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

        private void btnHome_Click(object sender, EventArgs e)
        {
            DealershipHome newForm = new DealershipHome();

            Hide();
            newForm.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                using (connection)
                {

                    connection.Open();
                    {

                        string command = "INSERT INTO Cars (CarReg, CarBrand, CarModel) VALUES ('BF12YUT', 'Honda', 'Jazz')";

                        var cmd = new SqlCommand(command, connection);
                        //cmd.Parameters.AddWithValue("@bar", 17);
                        cmd.ExecuteNonQuery();
                        
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
