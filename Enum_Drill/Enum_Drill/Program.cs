using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Create an enum for the days of the week.
//2. Prompt the user to enter the current day of the week.
//3. Assign the value to a variable of that enum data type you just created.
//4. Wrap the above statement in a try/catch block and have it print "Please enter
//an actual day of the week." to the console if an error occurs.

namespace Enum_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day of the week is it?");
                string currentDay = Console.ReadLine();
                Day day = (Day)Enum.Parse(typeof(Day), currentDay, true);
            }
            catch (Exception a)
            {
                Console.WriteLine("Please enter an actual day of the week", a);
                Console.ReadLine();
            }
           
        }
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    }
}
