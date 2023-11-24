﻿using System;
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
    public partial class DealershipHome : Form
    {         
        public DealershipHome()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            string sql = $"SELECT DISTINCT CarModel, CarBrand, CarReg FROM Cars";

            comboBoxBrands.Items.Clear();
            comboBoxBrands.Items.Add("All");

            QueryHandler queryHandler = new QueryHandler();

            List<Car> cars = queryHandler.SelectDB(sql);

            foreach (Car car in cars)
            {
                if (!comboBoxBrands.Items.Contains(car.Brand))
                {
                    comboBoxBrands.Items.Add($"{car.Brand}");
                }
            }
        }
       
        private void DealershipHome_Load(object sender, EventArgs e)
        {
            Refresh(); 
        }

        private void btnAddNewCars_Click(object sender, EventArgs e)
        {
            DealershipNewCar newForm = new DealershipNewCar();

            newForm.Show();               
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            DealershipDeleteCar newForm = new DealershipDeleteCar();

            newForm.Show();
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            DealershipUpdate newForm = new DealershipUpdate();

            newForm.Show();
        }

        private void comboBoxBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxBrands.Text;
        
            listBoxCar.Items.Clear();

            string sql = (selected.Equals("All")) ? $"SELECT CarModel, CarBrand, CarReg FROM Cars" : $"SELECT CarModel, CarBrand, CarReg FROM Cars WHERE CarBrand = '{selected}'";

            QueryHandler queryHandler = new QueryHandler();

            List<Car> cars = queryHandler.SelectDB(sql);

            foreach (Car car in cars)
            {
                listBoxCar.Items.Add($"{car.Brand} {car.Model} {car.Reg}\n");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
