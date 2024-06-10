using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Medley_Car_Care
{
    internal class Employee : Person
    {
        string CNIC = "";
        string address = "";
        public Image Photo = Image.FromFile("Anon_Image.png");
    }
}
