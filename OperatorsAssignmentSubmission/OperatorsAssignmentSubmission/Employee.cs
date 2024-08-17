using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignmentSubmission
{
        // Define the Employee class with Id, FirstName, and LastName properties
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Overload the == operator to compare Employee objects by their Id property
            public static bool operator ==(Employee emp1, Employee emp2)
            {
                // Check if both objects are null or if one is null
                if (ReferenceEquals(emp1, emp2))
                    return true;
                if (emp1 is null || emp2 is null)
                    return false;

                // Compare the Id properties
                return emp1.Id == emp2.Id;
            }

            // Overload the != operator to ensure it is consistent with the == operator
            public static bool operator !=(Employee emp1, Employee emp2)
            {
                return !(emp1 == emp2);
            }

            // Override the Equals method to ensure consistency with the overloaded operators
            public override bool Equals(object obj)
            {
                if (obj is Employee emp)
                {
                    return this.Id == emp.Id;
                }
                return false;
            }

            // Override the GetHashCode method to ensure consistency with the Equals method
            public override int GetHashCode()
            {
                return this.Id.GetHashCode();
            }
        }
}
