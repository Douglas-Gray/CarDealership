using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    internal class Car
    {
        public string Reg { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public Car(string reg, string brand, string model, string colour)
        {
            Reg = reg;
            Brand = brand;
            Model = model;
            Colour = colour; 
        }

    }
}
