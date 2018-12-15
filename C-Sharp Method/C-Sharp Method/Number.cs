using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Method
{
 public class Number
 {    
       public int Sum(int num1, int num2)
    {
        
        int total;
        total = num1 + num2;
        return total;
    }
        public int Subtract(int num1, int num2)
        {
            int total;
            total = num1 - num2;
            return total;
        }
        public int Multiply(int num1, int num2)
        {
            int total;
            total = num1 * num2;
            return total;
        }
    }
}
