using System;

namespace StructAssignment
{
        // Define a struct called Number
        struct Number
        {
            // Define a property called Amount of type decimal
            public decimal Amount { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create an instance of the Number struct
                Number myNumber = new Number();

                // Assign a value to the Amount property
                myNumber.Amount = 123.45m;

                // Print the value of the Amount property to the console
                Console.WriteLine("The amount is: " + myNumber.Amount);

                // Wait for user input before closing the console window
                Console.ReadLine();
            }
        }
}
