using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car:Vehicle
    {
        public string type;
        public static int numberOfCars;

        public Car(string make, string model, int price): base (make, model, price)
        {
            this.type = "car";
            numberOfCars++;
        }
    }
}
