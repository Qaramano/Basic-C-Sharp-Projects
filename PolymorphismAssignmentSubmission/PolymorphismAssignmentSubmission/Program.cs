using System;

namespace PolymorphismAssignmentSubmission
{
    class Program
    {
         // Main program class
        // Main method - entry point of the application
            static void Main(string[] args)
            {
                // Create an object of type IQuittable using polymorphism
                IQuittable quittable = new Employee();

                // Call the Quit method on the IQuittable object
                quittable.Quit();

                // Wait for user input before closing the console window
                Console.ReadLine();
            }
    }

}

