using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee object with a first name and last name
        Employee employee = new Employee
        {
            FirstName = "Sample",
            LastName = "Student",
            Id = 1 // Assign an ID to the employee
        };

        // Call the SayName method from the Person class on the Employee object
        employee.SayName();

        // Keep the console window open
        Console.ReadLine();
    }
}
