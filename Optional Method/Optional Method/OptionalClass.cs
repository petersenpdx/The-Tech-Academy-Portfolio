using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Method
{
    public class OptionalClass
    {
        
        public void Integer(int num1, int num2 = 3)
            {
            
            int total = num1 + num2;
                Console.WriteLine(total);
                return; 
            }


        
    }
}
