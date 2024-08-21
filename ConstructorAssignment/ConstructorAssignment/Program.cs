using System;

namespace ConstructorAssignment
{
        class Program
        {
            // Create a const variable
            const string greeting = "Hello, World!";

            static void Main(string[] args)
            {
                // Create a variable using the keyword "var"
                var number = 42;

                // Print the const variable
                Console.WriteLine(greeting);

                // Print the variable created with "var"
                Console.WriteLine("The number is: " + number);

                // Create an instance of the Person class using the default constructor
                Person person1 = new Person();
                Console.WriteLine(person1.GetInfo());

                // Create an instance of the Person class using the parameterized constructor
                Person person2 = new Person("John", 30);
                Console.WriteLine(person2.GetInfo());
            }
        }

        class Person
        {
            private string name;
            private int age;

            // Default constructor
            public Person() : this("Unknown", 0)
            {
                // This constructor calls the parameterized constructor with default values
            }

            // Parameterized constructor
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            // Method to get information about the person
            public string GetInfo()
            {
                return $"Name: {name}, Age: {age}";
            }
        }
    }
