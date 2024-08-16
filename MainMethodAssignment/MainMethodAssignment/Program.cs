using System;

namespace MathOperationsApp
{
    class MathOperations
    {
        // Method 1: Takes an integer, performs a math operation, and returns an integer
        public int PerformOperation(int input)
        {
            // Example: Add 10 to the input
            return input + 10;
        }

        // Method 2: Takes a decimal, performs a different math operation, and returns an integer
        public int PerformOperation(decimal input)
        {
            // Example: Multiply the input by 2 and convert to an integer
            return (int)(input * 2);
        }

        // Method 3: Takes a string, converts it to an integer, performs a different math operation, and returns an integer
        public int PerformOperation(string input)
        {
            // Example: Parse the input string and subtract 5
            if (int.TryParse(input, out int parsedInput))
            {
                return parsedInput - 5;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return 0; // Default value if parsing fails
            }
        }

        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            // Example usage:
            int integerResult = mathOps.PerformOperation(15);
            Console.WriteLine($"Method 1 result: {integerResult}");

            decimal decimalInput = 7.5M;
            int decimalResult = mathOps.PerformOperation(decimalInput);
            Console.WriteLine($"Method 2 result: {decimalResult}");

            string stringInput = "20";
            int stringResult = mathOps.PerformOperation(stringInput);
            Console.WriteLine($"Method 3 result: {stringResult}");
        }
    }
}
