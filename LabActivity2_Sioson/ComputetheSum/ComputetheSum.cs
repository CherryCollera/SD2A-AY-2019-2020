﻿/*
Sioson, Edward O.
BSCS-SD2A
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputetheSum
{
    class ComputetheSum
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum = {0} ", num1 + num2);
            Console.ReadLine();

        }
    }
}