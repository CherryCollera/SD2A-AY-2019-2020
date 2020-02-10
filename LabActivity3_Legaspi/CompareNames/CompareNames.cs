using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNames
{
    class CompareNames
    {
        static void Main(string[] args)
        {
            String string1 = "Kinit";
            String string2 = "Kinit";
            String string3 = "Kenneth";
            String string4 = "Kenneth";
            String string5 = "KENNETH";

            Console.WriteLine("Using Equals() method");
            Console.WriteLine("Compare {0} to {1}: {2}", string1, string2, String.Equals(string1, string2));
            Console.WriteLine("Compare {0} to {1}: {2}", string1, string3, String.Equals(string1, string3));
            Console.WriteLine("Length of {0} is {1}", string1, string1.Length);
            Console.WriteLine("String {0} Substring(0, 3) will return {1}", string5, string5.Substring(0, 3));
            Console.WriteLine("");

            Console.WriteLine("Using Compare() method");
            Console.WriteLine("Compare {0} to {1}: {2}", string1, string2, String.Compare(string1, string2));
            Console.WriteLine("Compare {0} to {1}: {2}", string1, string3, String.Compare(string1, string3));
            Console.WriteLine("Compare {0} to {1}: {2}", string3, string1, String.Compare(string3, string1));
            Console.WriteLine("Compare {0} to {1}: {2}", string4, string5, String.Equals(string4, string5));
            Console.WriteLine("");

            Console.WriteLine("Using CompareTo() method");
            Console.WriteLine("Compare {0} to {1}: {2}", string1, string2, string1.CompareTo(string2));
            Console.WriteLine("Compare {0} to {1}: {2}", string1, string3, string1.CompareTo(string3));
            Console.WriteLine("Compare {0} to {1}: {2}", string3, string1, string3.CompareTo(string1));


            Console.ReadKey();
        }
    }
}
