using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//REQUIREMENTS
//The program must start by printing “The Tech Academy”.
//The next line below that must be “Student Daily Report”
//You must ask and save to a well-named variable and proper data type answers to the following questions:
//What course are you on?
//What page number?
//Do you need help with anything? Please answer “true” or “false”.
//Were there any positive experiences you’d like to share? Please give specifics.
//Is there any other feedback you’d like to provide? Please be specific.
//How many hours did you study today?
//After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond to this shortly.Have a great day!” This would be the end of the program.

namespace C_Sharp_Ex.pg_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string yourNumber = Console.ReadLine();
            int courseNumber = Convert.ToInt32(yourNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool anyhelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string details = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string yourStudyHours = Console.ReadLine();
            int StudyHours = Convert.ToInt16(yourStudyHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();
        }
    }
}
