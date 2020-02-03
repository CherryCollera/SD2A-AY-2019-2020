using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    class BasicOperations
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, diff, prod;
            double quo, rem;
            Console.Write("Enter first number:      ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:      ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            sum = num1 + num2;
            Console.WriteLine("Sum = {0}", sum +".");

            diff = num1 - num2;
            Console.WriteLine("Difference = {0}", diff + ".");

            prod = num1 * num2;
            Console.WriteLine("Product = {0}", prod + ".");

            quo = num1 / num2;
            Console.WriteLine("Quotient = {0}", quo + ".");

            rem = num1 % num2;
            Console.WriteLine("Remainder = {0}", rem + ".");
            Console.ReadKey();
        }
    }
}
