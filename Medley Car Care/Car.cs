using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medley_Car_Care
{
    internal class Car
    {
        string color = ""; 
        string number = "";
        int mileage;

        public Car(string color, string number, int mileage)
        {
            this.color = color;
            this.number = number;
            this.mileage = mileage;
        }

        public Car() { }
    }
}
