using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_MathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //            CREATE A CONSOLE APPLICATION THAT DOES THE FOLLOWING:
            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).

            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.

            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.

            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            double inputInt = Convert.ToDouble(input);
            double product = inputInt * 50;
            Console.WriteLine("50 multiplied your number is:" + product);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            string input1 = Console.ReadLine();
            int inputAdd = Convert.ToInt32(input1);
            int InputAddition = inputAdd + 25;
            Console.WriteLine("25 added to your number is:" + InputAddition);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            string input2 = Console.ReadLine();
            double inputDiv = Convert.ToDouble(input2);
            double InputDivide = inputDiv / 12.5;
            Console.WriteLine("Your number divided by 12.5 is:" + InputDivide);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            string input3 = Console.ReadLine();
            int inputBool= Convert.ToInt32(input3);
            bool TrueOrFalse = inputBool > 50;
            Console.WriteLine("Your number is greater than 50:" + TrueOrFalse);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            string input4 = Console.ReadLine();
            int inputRem = Convert.ToInt32(input4);
            int InputRemainder = inputRem % 7;
            Console.WriteLine("The remainer of your number when it's devided by 7 is:" + InputRemainder);
            Console.ReadLine();



        }
    }

}
