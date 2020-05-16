using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Prints the current date and time to the console.
//2. Asks the user for a number.
//3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
             {
                DateTime currentTime = DateTime.Now;
                Console.WriteLine(currentTime);

                Console.WriteLine("Input a interger. The time will be modified in hours, based on the input.");
                string hoursLater = Console.ReadLine();
                int HoursLater = Convert.ToInt32(hoursLater);
                DateTime twoHoursLater = currentTime.AddHours(HoursLater);
                Console.WriteLine(twoHoursLater);
                Console.ReadLine();

            }

        }
    }
}
