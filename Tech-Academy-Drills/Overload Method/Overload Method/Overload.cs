using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Method
{
    class Overload
    {
        public void divideTwo(int number)
        {
           Console.WriteLine(number/2);
        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static void outPut(int x)
        {
            Console.WriteLine("outPut(int x)");
        }

        public static void outPut(string y)
        {
            Console.WriteLine("outPut(string y)");
        }
        
    }
}
