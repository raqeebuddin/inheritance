using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public string make;
        public string model;
        public int price;
        public bool sold;

        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.sold = false;
        }
    }
}
