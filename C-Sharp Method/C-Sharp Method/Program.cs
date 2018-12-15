using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Method;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an 
//    integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.
//2. In the Main() program, ask the user what number they want to do the math operations on.
//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

namespace C_Sharp_Method
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter in a number you would like to do math operations on: ");
            int UserNumber = Convert.ToInt16(Console.ReadLine());

            C_Sharp_Method.Number Add = new Number();
            {
                Console.WriteLine(Add.Sum(UserNumber, 5));
                Console.ReadLine();
            }

            C_Sharp_Method.Number Subtract = new Number();
            {
                Console.WriteLine(Subtract.Subtract(UserNumber, 5));
                Console.ReadLine();
            }
            C_Sharp_Method.Number Multiply = new Number();
            {
                Console.WriteLine(Multiply.Multiply(UserNumber, 5));
                Console.ReadLine();
            }

        }
    }  
}
