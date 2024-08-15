using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssignmentPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1
            //one - dimensional array of strings
            string[] myString =
            {
                "My name ",
                "is, ",
            };
            string[] myString2 =
            {
                "I am A student ",
                "at the Academy."
            };
            List<string> list1 = new List<string>();
            //asking the user for some text input
            Console.WriteLine("Please enter a name:");
            list1.Add(Console.ReadLine());
            Console.WriteLine("Please enter a someone's name:");
            list1.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjective");
            list1.Add(Console.ReadLine());
            //create a loop to go through each string in the array adding the user text to the string
            for (int i = 0; i < myString.Length; i++)
            {
                myString[i] += list1[i];
                Console.WriteLine(myString[i] + myString2[i]);
            }
            Console.ReadLine();
            Console.WriteLine("The Strings we used:");
            //a loop to print off each string
            for (int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine(myString[i] + myString2[i]);
                //P2
                //an infinte loop
                //fix th infinte loop
                //i--;
            }
            Console.ReadLine();

            //P3
            Console.WriteLine("Is that a ghost?!");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");
            //a loop where the comparsion used to determine where to continue iterationg the loop is a "<" operator
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            boo.Append("!");
            Console.ReadLine();
            Console.WriteLine(boo);
            Console.ReadLine();
            StringBuilder ahh = new StringBuilder();
            ahh.Append("A");
            //a loop where the comparison that used to determine whethere to continue iterating the loop is a "<=" operator
            while (ahh.Length <= 10)
            {
                ahh.Append("h");
            }
            ahh.Append("!");
            Console.WriteLine(ahh);
            Console.ReadLine();

            //P4
            //create a list of strings where each item in the list is unique
            List<string> teams = new List<string>() { "Bucks", "Raptors", "Celtics", "Heat", "Pacers", "76ers", "Nets", "Magic", "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers" };
            Console.WriteLine("NBA Eastren Conference Standing");
            //ask the user to input text to search fo in th list
            Console.WriteLine("Enter team name:");
            int standing = 0;
            bool isValid = false;
            int index = 0;
            //a loop that iterates through the list and then displays the index of the array that contains matching text on the screen
            while (!isValid)
            {
                int i2 = 0;
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {
                    if (teamrequest == team)
                    {
                        standing = i2 + 1;
                        index = i2;
                    }
                    i2++;
                }
                //adding code to that above loop that tells a user if they put in text that isn't in the list
                if (standing == 0)
                {
                    Console.WriteLine("That is mot a valid team name. Enter again:");
                }
                //add code to that above loop taht stops it from executing once a match has been found
                else
                {
                    isValid = true;
                }
                Console.WriteLine("Processind... index is: " + index + ". So...");
                Console.WriteLine("Standing is: " + standing);
                Console.ReadLine();

                //P5
                //a list of strings that has at least 2 identical strings in the list
                List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" };
                Console.WriteLine("Welcome to Swell Taco! \nDue to covid-19 we have a computerized check-in.\nIf you have a reservation tupe " +
                    "\"Reserved\".\nIf you are joining a party that is already here type \"Taken\".\nOtherwise type \"Vacant\".");
                //ask the user to select text to search for in the list
                Console.WriteLine("Enter selection:");
                string selection = Console.ReadLine();
                while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
                {
                    //add code that tells a user if they put in text that isn't in the list
                    Console.WriteLine("Please enter one of the 3 choices:");
                    selection = Console.ReadLine();
                }

                Console.WriteLine("The tables that match your selection are numbered:");
                //create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen
                for (int i3 = 0; i3 < tables.Count; i3++)
                {
                    if (selection == tables[i3])
                    {
                        Console.WriteLine(i3);
                    }
                }
                Console.ReadLine();
                //P6
                //create a list of strings that has at least 2 identical strings in the list
                List<string> names = new List<string>() { "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };
                List<string> repeatcheck = new List<string>();
                Console.WriteLine("Class Roster:");
                //create a foreach that evaluates each item in the list and displays a message shoing the string an whetheror not it has already appeared in the lsit 
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                    if (repeatcheck.Contains(name))
                    {
                        Console.WriteLine("this name has been repeated. \nuse last name  inistial when referring to this student.");
                    }
                    else
                    {
                        Console.WriteLine("This name has not been repeated.");
                    }
                    repeatcheck.Add(name);
                }
                Console.ReadLine();
            }






            



        }
    }
}
