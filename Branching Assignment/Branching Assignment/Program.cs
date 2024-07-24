using System;

namespace Branching_Assignment
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt for package dimensions
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if the package is too big
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate the quote
            double quote = (width * height * length * weight) / 100;

            // Display the quote
            Console.WriteLine($"Your estimated shipping cost is: ${quote:F2}");
        }
    }

}
