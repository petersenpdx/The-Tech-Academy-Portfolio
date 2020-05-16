using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Create a class. In that class, create a void method that outputs 
//an integer.Have the method divide the data passed to it by 2.
//2. In the Main() method, instantiate that class.
//3. Have the user enter a number.Call the method on that number.Display 
//the output to the screen. It should be the entered number, divided by two.
//4. Create a method with output parameters.
//5. Overload a method.
//6. Declare a class to be static.

namespace Overload_Method
{
    class Program
    {
        public static void Main(string[] args)

        {
             Overload Integer = new Overload();
            {
                
                Console.WriteLine("Pick a whole number to divide by 2");
                int number = Convert.ToInt32(Console.ReadLine());

                Overload exampleOne = new Overload();
                exampleOne.divideTwo(number);
                Console.ReadLine();


                Overload exampleTwo = new Overload();
                int a, b;
                exampleTwo.getValues(out a, out b);
                Console.WriteLine("Call method w/ value of a: {0}", a);
                Console.WriteLine("Call methode w/ value of b: {0}", b);
                Console.ReadLine();

                Overload exampleThree = new Overload();
                Overload.outPut("text");
                Console.ReadLine();

            }
        }
    }
}
