using System;
class Program
{
    static void Main()
    {
        MathOperations mathOps = new MathOperations();

        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (optional): ");
        string secondNumberInput = Console.ReadLine();

        // Parse the second number (if provided), or use the default value (0)
        int secondNumber = string.IsNullOrEmpty(secondNumberInput)
            ? 0
            : Convert.ToInt32(secondNumberInput);

        // Call the method and display the result
        int result = mathOps.PerformMathOperation(firstNumber, secondNumber);
        Console.WriteLine($"Result of the operation: {result}");
    }
}
