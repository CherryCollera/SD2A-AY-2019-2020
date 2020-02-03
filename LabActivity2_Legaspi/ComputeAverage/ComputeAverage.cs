using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverage
{
    class ComputeAverage
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, num5, ave;
            Console.WriteLine("Enter five (5) Grades:");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            num4 = Convert.ToDouble(Console.ReadLine());
            num5 = Convert.ToDouble(Console.ReadLine());

            ave = (num1 + num2 + num3 + num4 + num5) / 5;

            Console.Write("The average is {0:0.000}.", ave);
            Console.ReadKey();
        }
    }
}
