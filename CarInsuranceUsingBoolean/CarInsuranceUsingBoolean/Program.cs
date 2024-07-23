using System;

namespace CarInsuranceUsingBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
           
                // Ask for applicant's age
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());

                // Ask if the applicant has ever had a DUI
                Console.WriteLine("Have you ever had a DUI? (true/false)");
                string duiInput = Console.ReadLine().ToLower();
                bool hasDui = duiInput == "true";

                // Ask for the number of speeding tickets
                Console.WriteLine("How many speeding tickets do you have?");
                int speedingTickets = Convert.ToInt32(Console.ReadLine());

                // Determine if the applicant qualifies for car insurance
                bool isQualified = (age > 15) && !hasDui && (speedingTickets <= 3);

                // Print the result
                Console.WriteLine("Qualified for car insurance: " + isQualified);
        }
    }
}
