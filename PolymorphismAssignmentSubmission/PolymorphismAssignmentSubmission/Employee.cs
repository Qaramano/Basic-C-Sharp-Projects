using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignmentSubmission
{
    // Define a class called Employee that implements the IQuittable interface
    public class Employee : IQuittable
    {
        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Print a message indicating the employee has quit
            Console.WriteLine("The employee has quit.");
        }
    }

}
