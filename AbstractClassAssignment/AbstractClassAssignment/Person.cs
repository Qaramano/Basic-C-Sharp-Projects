using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{

        // Abstract class Person with two properties: firstName and lastName
        public abstract class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }

            // Abstract method SayName to be implemented by derived classes
            public abstract void SayName();
        }
    }
