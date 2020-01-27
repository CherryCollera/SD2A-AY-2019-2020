using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3_InputMyName
{
    class KennethLegaspi
    {
        static void Main(string[] args)
        {
            string fname, lname;

            Console.Write("Enter your name (firstname lastname): ");
            fname = Console.ReadLine();
            lname = Console.ReadLine();
            Console.WriteLine("Hello " + fname + lname + "!!!\nWelcome to OOP Environment");
            Console.ReadKey();
        }
    }
}
