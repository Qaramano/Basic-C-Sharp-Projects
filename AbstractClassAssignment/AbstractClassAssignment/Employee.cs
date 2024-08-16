using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    // Employee class inheriting from Person
    public class Employee : Person
    {
        // Implementing the SayName method
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}
    

