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
                QueryHandler queryHandler = new QueryHandler();

                MessageBox.Show(queryHandler.UpdateDB(sql));
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
