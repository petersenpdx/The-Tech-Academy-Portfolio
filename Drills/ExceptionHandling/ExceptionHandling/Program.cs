using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Ask the user for his age.
//2. Display the year user born.
//3. Exceptions must be handled using "try .. catch".
//4. Display appropriate error messages if user enters zero or negative numbers.
//5. Display a general message if exception caused by anything else.

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the exception handling test program.");
            bool boolAnswer = false;
            int age = 0;
            while (!boolAnswer)
            {
                try
                {
                    Console.Write("Please enter your age: ");
                    age = Convert.ToInt16(Console.ReadLine());
                    if (age <= 0)
                    {
                    throw new ArgumentException();
                    }
                    else 
                    {
                        //2.Display the year user born.
                        boolAnswer = true;
                        var thisYear = DateTime.Now.Year;
                        var yearBorn = thisYear - age;
                        Console.WriteLine("You where born in {0} or {1} (depending on the time of the year)", yearBorn, yearBorn - 1);
                        Console.ReadLine();
                    }
                  
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter a number greater than 0.");
                }
                catch (Exception)
                {
                    //5.Display a general message if exception caused by anything else.
                    Console.WriteLine("Please enter your age as a whole number only.");
                
                }
            }
        }
    }
}