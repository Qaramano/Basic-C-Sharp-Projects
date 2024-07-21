using System;

namespace Math_and_Comparison_Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        
            {
                Console.WriteLine("Anonymous Income Comparison Program");

                // Person 1
                Console.WriteLine("Person 1");
                Console.Write("Hourly Rate: ");
                decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Hours worked per week: ");
                int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());

                // Person 2
                Console.WriteLine("Person 2");
                Console.Write("Hourly Rate: ");
                decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Hours worked per week: ");
                int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());

                // Calculate annual salaries
                decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
                decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

                // Output annual salaries
                Console.WriteLine("Annual salary of Person 1: " + annualSalary1);
                Console.WriteLine("Annual salary of Person 2: " + annualSalary2);

                // Compare salaries
                bool person1MakesMore = annualSalary1 > annualSalary2;
                Console.WriteLine("Person 1 makes more money than Person 2: " + person1MakesMore);
            }
        }

    }