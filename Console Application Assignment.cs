using System;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
            {
                // Task 1: Multiply input by 50
                Console.WriteLine("Enter a number to multiply by 50:");
                double input1 = Convert.ToDouble(Console.ReadLine());
                double result1 = input1 * 50;
                Console.WriteLine("Result of multiplication: " + result1);

                // Task 2: Add 25 to input
                Console.WriteLine("Enter a number to add 25 to:");
                double input2 = Convert.ToDouble(Console.ReadLine());
                double result2 = input2 + 25;
                Console.WriteLine("Result of addition: " + result2);

                // Task 3: Divide input by 12.5
                Console.WriteLine("Enter a number to divide by 12.5:");
                double input3 = Convert.ToDouble(Console.ReadLine());
                double result3 = input3 / 12.5;
                Console.WriteLine("Result of division: " + result3);

                // Task 4: Check if input is greater than 50
                Console.WriteLine("Enter a number to check if it is greater than 50:");
                double input4 = Convert.ToDouble(Console.ReadLine());
                bool isGreaterThan50 = input4 > 50;
                Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

                // Task 5: Divide input by 7 and print the remainder
                Console.WriteLine("Enter a number to divide by 7 and get the remainder:");
                double input5 = Convert.ToDouble(Console.ReadLine());
                double remainder = input5 % 7;
                Console.WriteLine("Remainder when divided by 7: " + remainder);
            }
        }
    }