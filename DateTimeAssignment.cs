using System;

namespace DatetimeAssignment
{
        class Program
        {
            static void Main(string[] args)
            {
                // Print the current date and time to the console
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine("Current Date and Time: " + currentDateTime);

                // Ask the user for a number
                Console.Write("Enter a number of hours: ");
                string input = Console.ReadLine();
                int hours;

                // Validate the user input to ensure it's a valid integer
                while (!int.TryParse(input, out hours))
                {
                    Console.Write("Invalid input. Please enter a valid number of hours: ");
                    input = Console.ReadLine();
                }

                // Calculate the exact time it will be in X hours
                DateTime futureDateTime = currentDateTime.AddHours(hours);
                Console.WriteLine("In " + hours + " hours, it will be: " + futureDateTime);

                // Keep the console window open
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
}