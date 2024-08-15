using System;
using System.Collections.Generic;

namespace ConsoleAppStringsandIntegersAssignment
{
    class Program
    {
            static void Main(string[] args)
            {
                // Create an empty list to store integers
                var integerList = new List<int>();

                // Ask the user for input and populate the list with integers
                while (true)
                {
                    Console.Write("Enter an integer (or 'done' to finish): ");
                    var userInput = Console.ReadLine();
                    if (userInput.ToLower() == "done")
                        break;

                    if (int.TryParse(userInput, out int number))
                        integerList.Add(number);
                    else
                        Console.WriteLine("Invalid input. Please enter a valid integer or 'done'.");
                }

                // Ask the user for a number to divide each integer in the list
                double divisor;
                while (true)
                {
                    Console.Write("Enter a number to divide by: ");
                    var divisorInput = Console.ReadLine();
                    if (double.TryParse(divisorInput, out divisor))
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                // Initialize a list to store the results of division
                var results = new List<double>();

                // Perform division and display results
                foreach (var num in integerList)
                {
                    try
                    {
                        var result = num / divisor;
                        results.Add(result);
                        Console.WriteLine($"{num} divided by {divisor} is {result:F2}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Error: Cannot divide by zero for {num}.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                // Print a message after the try/catch block
                Console.WriteLine("Program execution continued after handling exceptions.");
            }
    }
}
 
