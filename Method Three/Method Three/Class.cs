using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Three
{
    public class Class
    {
        
        public int The(int num1)
        {
            int total = num1 + 3;
            Console.WriteLine(total);
            return total;
        }

        public decimal Dec(decimal num1)
        {
            decimal total = num1 * 3.3m;
            Console.WriteLine(total);
            return total;
        }

        public void Word(string numString)
        {

            int Num = Convert.ToInt16(numString);
            int total = 20 - Num;
            Console.WriteLine(total);
            return;
        }

    }
}
