/*
Sioson, Edward O.
BSCS-SD2A
*/

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
            int num1, num2;
            int sum, difference, product;
            double quotient, remainder;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            difference = num1 - num2;
            product = num1 * num2;
            quotient = num1 / num2;
            remainder = num1 % num2;

            Console.WriteLine("\nSum = {0}.", sum);
            Console.WriteLine("Difference = {0}.", difference);
            Console.WriteLine("Product = {0}.", product);
            Console.WriteLine("Quotient = {0}.", quotient);
            Console.Write("Remainder = {0}.", remainder);
            Console.ReadLine();

        }
    }
}

