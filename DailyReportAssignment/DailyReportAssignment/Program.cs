using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy Of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is Your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("What Course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What Page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string NHelp = Console.ReadLine();
            bool NHelpbool = bool.Parse(NHelp);
            Console.WriteLine("Were there any positive experience you would like to share? Please give specifics.");
            string posExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to provide? Please give specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}