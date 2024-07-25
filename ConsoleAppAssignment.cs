using System;

namespace BooleanComparisonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a counter variable
            int counter = 0;

            // While loop with a boolean comparison
            while (counter < 3)
            {
                // Print the current value of the counter
                Console.WriteLine($"While loop iteration: {counter}");

                // Increment the counter
                counter++;
            }

            // Reset the counter for the do-while loop
            counter = 0;

            // Do-while loop with a boolean comparison
            do
            {
                // Print the current value of the counter
                Console.WriteLine($"Do-while loop iteration: {counter}");

                // Increment the counter
                counter++;
            } while (counter < 3);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
