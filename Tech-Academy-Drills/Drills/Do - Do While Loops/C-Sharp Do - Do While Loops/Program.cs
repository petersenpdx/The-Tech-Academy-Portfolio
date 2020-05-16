using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Do a boolean comparison using a while statement.

//2. Do a boolean comparison using a do while statement.

namespace C_Sharp_Do___Do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2. DO-WHILE LOOP

            Console.WriteLine("What is an odd number between 0 and 9?");
            int odd = Convert.ToInt16(Console.ReadLine());
            bool isGuessed = false;

            while(!isGuessed)
           
            switch (odd)
            {
                case 0:
                    Console.WriteLine("Wrong. 0 is an even number. Try again.");
                        Console.WriteLine("What is an odd number between 0 and 9?");
                        odd = Convert.ToInt16(Console.ReadLine());
                        break;
                case 2:
                    Console.WriteLine("Wrong. 2 is an even number. Try again.");
                        Console.WriteLine("What is an odd number between 0 and 9?");
                        odd = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 4:
                    Console.WriteLine("Wrong. 4 is an even number. Try again.");
                        Console.WriteLine("What is an odd number between 0 and 9?");
                        odd = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 6:
                    Console.WriteLine("Wrong. 6 is an even number. Try again.");
                        Console.WriteLine("What is an odd number between 0 and 9?");
                        odd = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 8:
                    Console.WriteLine("Wrong. 8 is an even number. Try again.");
                        Console.WriteLine("What is an odd number between 0 and 9?");
                        odd = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 1:
                    Console.WriteLine("Correct! 1 is an odd number");
                        isGuessed = true;
                        break;
                    case 3:
                    Console.WriteLine("Correct! 3 is an odd number");
                        isGuessed = true;
                        break;
                    case 5:
                    Console.WriteLine("Correct! 5 is an odd number");
                        isGuessed = true;
                        break;
                    case 7:
                    Console.WriteLine("Correct! 7 is an odd number");
                        isGuessed = true;
                        break;
                    case 9:
                    Console.WriteLine("Correct! 9 is an odd number");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("This number is not between 0 and 9. Try again.");
                        Console.WriteLine("What is an odd number between 0 and 9?");
                        odd = Convert.ToInt16(Console.ReadLine());
                        break;
                }
            Console.ReadLine();


            // DO - SWITCH STATEMENT 
            //Console.WriteLine("State odd numbers 0-9");
            //int odd = Convert.ToInt16(Console.ReadLine());

            //    switch (odd)
            //    {
            //        case 0:
            //            Console.WriteLine("Wrong. 0 is an even number");
            //            break;
            //        case 2:
            //            Console.WriteLine("Wrong. 2 is an even number");
            //            break;
            //        case 4:
            //            Console.WriteLine("Wrong. 4 is an even number");
            //            break;
            //        case 6:
            //            Console.WriteLine("Wrong. 6 is an even number");
            //            break;
            //        case 8:
            //            Console.WriteLine("Wrong. 8 is an even number");
            //            break;
            //        case 1:
            //            Console.WriteLine("Correct! 1 is an odd number");
            //            break;
            //        case 3:
            //            Console.WriteLine("Correct! 3 is an odd number");
            //            break;
            //        case 5:
            //            Console.WriteLine("Correct! 5 is an odd number");
            //            break;
            //        case 7:
            //            Console.WriteLine("Correct! 7 is an odd number");
            //            break;
            //        case 9:
            //            Console.WriteLine("Correct! 9 is an odd number");
            //            break;

            //        default:
            //            Console.WriteLine("This integer is not between 0 and 9. ");
            //            break;
            //    }
        }
    }
}
