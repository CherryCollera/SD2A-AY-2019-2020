using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3_InputMyName
{
    class Sample3_InputMyName
    {
        static void Main(string[] args)
        {
            String firstname, lastname;

            Console.Write("Enter Your Name (firstname lastname) ");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.Write("Hello " + firstname + "" + lastname + "!!! \nWelcome To OOP Enviroment.");
            Console.ReadKey();
        }
    }
}
