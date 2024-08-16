using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the method, passing in two numbers (e.g., 5 and 10)
        mathOps.PerformMathOperation(5, 10);

        // Call the method, specifying the parameters by name
        mathOps.PerformMathOperation(num1: 7, num2: 15);

        // Add comments to explain the code:
        // - We create a MathOperations class with a method called PerformMathOperation.
        // - The method takes two integers (num1 and num2) as parameters.
        // - It multiplies num1 by 2 and displays the result (num2).
        // - In Main(), we instantiate the class and call the method twice.
    }
}
