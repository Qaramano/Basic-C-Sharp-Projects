using System;

namespace codeFirstEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var schoolContext = new SchoolContext())
            {
                var stud = new Student() { ID = 01, StudentName = "Omar Kraman" };

                schoolContext.Students.Add(stud);
                schoolContext.SaveChanges();

                Console.Write("Entry Saved successfully!");

            }
            Console.ReadLine();
        }
    }
}