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
        public DealershipDeleteCar()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string carReg = txtCarReg.Text;

            string sql = $"DELETE FROM Cars WHERE CarReg = '{carReg}'";


            if (carReg.Length <= 0 || carReg.Length > 7)
            {
                MessageBox.Show("Please valid data to input record to database");
                lblRegValidation.Text = "Car registration 1 - 7 Characters";
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
    }
}
