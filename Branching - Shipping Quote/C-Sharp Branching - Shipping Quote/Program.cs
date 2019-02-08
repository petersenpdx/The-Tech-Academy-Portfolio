using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE: BRANCHING
//Your job is to create a console-based application for getting a shipping quote for a package.
//REQUIREMENTS
//The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
//The user must then be prompted for the package weight.
//If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
//The user must then be prompted for the package width.
//Then the package height.
//Then the package length.
//If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
//The sum total of dimensions are then multiplied by the weight and divided by 100.
//The result of that calculation is the quote.
//Display the quote to the user as a dollar amount.

namespace C_Sharp_Branching___Shipping_Quote
{
//    EXAMPLE
//Welcome to Package Express. Please follow the instructions below.
//Please enter the package weight:
//40
//Please enter the package width:
//5
//Please enter the package height:
// 3
//Please enter the package length:
// 3
//Your estimated total for shipping this package is: $4.40
//Thank you.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt16(Console.ReadLine());
            if (50 < weight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
             }
          
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Please eneter the package height:");
                int height = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Please eneter the package length:");
                int length = Convert.ToInt16(Console.ReadLine());

                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is:" + "$"  + (weight * (width + height + length)) / 100);
                    Console.ReadLine();
                }
            }
        }
    }
}
