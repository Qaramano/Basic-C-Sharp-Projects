using System;

namespace MyMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MathOperations
            var mathOps = new MathOperations();

            // Ask the user for input
            Console.Write("Enter an integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call each method and display the results
            int resultAdd = mathOps.Add(userInput);
            int resultSubtract = mathOps.Subtract(userInput);
            int resultDivide = mathOps.Divide(userInput);

            Console.WriteLine($"Result after addition: {resultAdd}");
            Console.WriteLine($"Result after subtraction: {resultSubtract}");
            Console.WriteLine($"Result after division: {resultDivide}");
        }
    }
}
