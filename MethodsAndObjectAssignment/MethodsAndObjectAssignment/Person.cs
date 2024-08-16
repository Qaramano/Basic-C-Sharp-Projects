using System;
using System.Collections.Generic;
using System.Text;


    // Define a class called Person with two string properties: FirstName and LastName
    public class Person
    {
        // Property to store the first name
        public string FirstName { get; set; }

        // Property to store the last name
        public string LastName { get; set; }

        // Method to print the full name to the console
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

