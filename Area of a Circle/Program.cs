using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calculating the area of a circle
            Console.WriteLine("Enter the value for radius");
            const double pi = 3.14;
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaOfCircle = (pi * (radius * radius));
            Console.WriteLine("The area of the Circle is {0}", areaOfCircle);
        }
    }
}
