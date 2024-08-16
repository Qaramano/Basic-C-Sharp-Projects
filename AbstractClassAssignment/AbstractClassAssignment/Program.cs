using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee { firstName = "Sample", lastName = "Student" };

            // Calling the SayName method on the Employee object
            employee.SayName();

            // Keeping the console window open
            Console.ReadLine();
        }
    }
}
