using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Cervantes
{
    class Average_Cervantes
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;
            double ave;
            Console.Write("Enter five grades: \n");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());
            ave = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.Write("Average = {0:0.00}",+ ave);
            Console.ReadLine();
        }
    }
    }

