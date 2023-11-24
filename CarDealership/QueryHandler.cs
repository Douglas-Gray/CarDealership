using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    internal class QueryHandler
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Douglas\source\repos\CarDealership\CarDealership\Cars.mdf; Integrated Security = True";
        public string UpdateDB(string sqlStatement) {

            string message = "";
            int queryCheck; 

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                using (connection)
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlStatement, connection))
                    {

                        queryCheck = command.ExecuteNonQuery();

                        if (queryCheck == 0)
                        {
                            message = "No record found to update";
                        }
                        else { message = "Record Updated"; }

                    }
                    connection.Close();
                }
            }
            catch (SqlException er)
            {
                MessageBox.Show("Failed to connect to Database!" + er.ToString());
                connection.Close();
            }

            return message; 
        }

        public List<Car> SelectDB(string sqlStatement)
        {
            List<Car> cars = new List<Car>();

            SqlConnection connection = new SqlConnection(connectionString);
            
            try
            {
                using (connection)
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlStatement, connection))
                    {
                        using (SqlDataReader carReader = command.ExecuteReader())
                        {
                            while (carReader.Read())
                            {
                                Car car = new Car((string)carReader["CarReg"], (string)carReader["CarBrand"], (string)carReader["CarModel"], (string)carReader["CarColour"]); 

                                cars.Add(car); 
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

            if (cars.Count <= 0)
            {
                Car car = new Car("N/A", "N/A", "N/A", "N/A");
                cars.Add(car); 
            }

            return cars; 
        }

    }
}
