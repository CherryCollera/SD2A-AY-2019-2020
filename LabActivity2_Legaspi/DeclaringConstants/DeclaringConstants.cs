using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main(string[] args)
        {
            double radius = 0, area;
            const double pi = 3.14159;

            Console.Write("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            double AreaCircle = pi * radius * radius;

            Console.Write("Radius: {0:0.0000}, ", radius);
            Console.Write("Area: {0:0.0000}", AreaCircle);
            Console.ReadKey();
        }
    }
}
