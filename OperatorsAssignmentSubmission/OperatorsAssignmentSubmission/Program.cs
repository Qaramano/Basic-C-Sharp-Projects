using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using OperatorsAssignmentSubmission;

namespace EmployeeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = emp1 == emp2;

            // Display the result of the comparison
            Console.WriteLine($"Are Employee 1 and Employee 2 equal? {areEqual}");

            // Change the Id of emp2 to match emp1
            emp2.Id = 1;

            // Compare the two Employee objects again
            areEqual = emp1 == emp2;

            // Display the result of the comparison
            Console.WriteLine($"Are Employee 1 and Employee 2 equal after changing Id? {areEqual}");
        }
    }
}
