using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class DealershipUpdate : Form
    {
        public DealershipUpdate()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            string selected = txtCurrentCarReg.Text;

            string sql = $"SELECT CarModel, CarBrand, CarReg, CarColour FROM Cars WHERE CarReg = '{selected}'";

            QueryHandler queryHandler = new QueryHandler();

            List<Car> cars = queryHandler.SelectDB(sql);

            Car car = cars[0]; 

            txtUpdateCarBrand.Text = car.Brand;
            txtUpdateCarModel.Text = car.Model;
            txtUpdateCarReg.Text = car.Reg.Trim();
            txtUpdateCarColour.Text = car.Colour; 
                       
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldCarReg = txtCurrentCarReg.Text; 
            string carReg = txtUpdateCarReg.Text;
            string carBrand = txtUpdateCarBrand.Text;
            string carModel = txtUpdateCarModel.Text;
            string carColour = txtUpdateCarColour.Text; 

            string sql = $"UPDATE Cars SET CarBrand = '{carBrand}', CarModel = '{carModel}', CarReg = '{carReg}', CarColour = '{carColour}' WHERE CarReg = '{oldCarReg}'";


            if (carReg.Length <= 0 || carReg.Length > 7 || carBrand.Length <= 0 || carModel.Length <= 0 || carColour.Length <= 0)
            {
                MessageBox.Show("Please valid data to input record to database");
                lblRegValidation.Text = "Car registration 1 - 7 Characters";
                lblBrandValidation.Text = "Car brand field required";
                lblModelValidation.Text = "Car model field required";
                lblColourValidation.Text = "Car colour field required"; 
            }
            else
            {
                QueryHandler queryHandler = new QueryHandler();

                MessageBox.Show(queryHandler.UpdateDB(sql)); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DealershipUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
