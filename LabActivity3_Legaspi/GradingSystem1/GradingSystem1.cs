using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem1
{
    class GradingSystem1
    {
        static void Main(string[] args)
        {
            string final_grade = null;
            int final_grade1 = 0;

            Console.Write("Enter your final grade: ");
            final_grade = Console.ReadLine();

            if (final_grade.Equals("INC") || final_grade.Equals("inc") || final_grade.Equals("Inc"))
            {
                Console.WriteLine("Grade Equivalent: Incomplete");
                Console.Write("Remarks: - ");
            }
            else
            {
                final_grade1 = Convert.ToInt32(final_grade);
                if (final_grade1 >= 98 && final_grade1 <= 100)
                {
                    Console.WriteLine("Grade Equivalent: 1.0");
                    Console.Write("Remarks: Excellent");
                }
                else if (final_grade1 >= 95 && final_grade1 <= 97)
                {
                    Console.WriteLine("Grade Equivalent: 1.25");
                    Console.Write("Remarks: Very Good");
                }
                else if (final_grade1 >= 92 && final_grade1 <= 94)
                {
                    Console.WriteLine("Grade Equivalent: 1.50");
                    Console.Write("Remarks: Very Good");
                }
                else if (final_grade1 >= 89 && final_grade1 <= 91)
                {
                    Console.WriteLine("Grade Equivalent: 1.75");
                    Console.Write("Remarks: Very Good");
                }
                else if (final_grade1 >= 86 && final_grade1 <= 88)
                {
                    Console.WriteLine("Grade Equivalent: 2.0");
                    Console.Write("Remarks: Good");
                }
                else if (final_grade1 >= 83 && final_grade1 <= 85)
                {
                    Console.WriteLine("Grade Equivalent: 2.25");
                    Console.Write("Remarks: Good");
                }
                else if (final_grade1 >= 80 && final_grade1 <= 82)
                {
                    Console.WriteLine("Grade Equivalent: 2.50");
                    Console.Write("Remarks: Fair");
                }
                else if (final_grade1 >= 77 && final_grade1 <= 79)
                {
                    Console.WriteLine("Grade Equivalent: 2.75");
                    Console.Write("Remarks: Passed");
                }
                else if (final_grade1 >= 75 && final_grade1 <= 76)
                {
                    Console.WriteLine("Grade Equivalent: 3.0");
                    Console.Write("Remarks: Passed");
                }
                else if (final_grade1 >= 72 && final_grade1 <= 74)
                {
                    Console.WriteLine("Grade Equivalent: 4.0");
                    Console.Write("Remarks: Conditional");
                }
                else if (final_grade1 >= 60 && final_grade1 <= 71)
                {
                    Console.WriteLine("Grade Equivalent: 5.0");
                    Console.Write("Remarks: Failed");
                }
            }
            

            Console.ReadKey();
        }
    }
}
