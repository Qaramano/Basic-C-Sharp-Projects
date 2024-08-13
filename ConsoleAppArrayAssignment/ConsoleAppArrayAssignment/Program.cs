using System;
using System.Collections.Generic;

namespace ArrayAndListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional Array of strings.
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date" };

            // Ask the user to select an index.
            Console.Write("Enter an index (0 to 3) for the string array: ");
            if (int.TryParse(Console.ReadLine(), out int stringIndex))
            {
                if (stringIndex >= 0 && stringIndex < stringArray.Length)
                {
                    // Display the string at the selected index.
                    Console.WriteLine($"String at index {stringIndex}: {stringArray[stringIndex]}");
                }
                else
                {
                    Console.WriteLine("Index out of range. Please select a valid index.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Create a one-dimensional Array of integers.
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index.
            Console.Write("Enter an index (0 to 4) for the integer array: ");
            if (int.TryParse(Console.ReadLine(), out int intIndex))
            {
                if (intIndex >= 0 && intIndex < intArray.Length)
                {
                    // Display the integer at the selected index.
                    Console.WriteLine($"Integer at index {intIndex}: {intArray[intIndex]}");
                }
                else
                {
                    Console.WriteLine("Index out of range. Please select a valid index.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Create a list of strings.
            List<string> stringList = new List<string> { "Lemon", "Grapes", "Orange", "Pear" };

            // Ask the user to select an index.
            Console.Write("Enter an index (0 to 3) for the string list: ");
            if (int.TryParse(Console.ReadLine(), out int listIndex))
            {
                if (listIndex >= 0 && listIndex < stringList.Count)
                {
                    // Display the content at the selected index.
                    Console.WriteLine($"Content at index {listIndex}: {stringList[listIndex]}");
                }
                else
                {
                    Console.WriteLine("Index out of range. Please select a valid index.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
