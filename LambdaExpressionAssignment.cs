using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LambdaExpressionAssignment
{
   
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees with at least 10 employees, including at least two named "Joe"
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Emily", LastName = "Davis" },
                new Employee { Id = 5, FirstName = "Michael", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Wilson" },
                new Employee { Id = 7, FirstName = "David", LastName = "Lee" },
                new Employee { Id = 8, FirstName = "Chris", LastName = "Kim" },
                new Employee { Id = 9, FirstName = "Anna", LastName = "Taylor" },
                new Employee { Id = 10, FirstName = "Joe", LastName = "White" }
            };

            // Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> joesForeach = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesForeach.Add(employee);
                }
            }

            // Using a lambda expression, create a new list of all employees with the first name "Joe"
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Using a lambda expression, create a new list of all employees with an Id number greater than 5
            List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

            // Output the results
            Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
            foreach (var joe in joesForeach)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with the first name 'Joe' (lambda expression):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with an Id greater than 5 (lambda expression):");
            foreach (var employee in idGreaterThanFive)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}
