using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator
{
    
        public class Employee : Person, IQuittable
        {
            public int id;
            public void Number()
            {
                id = 0;
            }
            public void Number(int x)
            {
                id = x;
            }
            public static bool operator ==(Employee x, Employee y)
            {
                if (x.id == y.id)
                {
                    Console.WriteLine("== yes");
                    return true;
                }
                else
                {
                    Console.WriteLine("== no");
                    return false;
                }
            }
            public static bool operator !=(Employee x, Employee y)
            {
                if (x.id != y.id)
                {
                    Console.WriteLine("!= yes");
                    return true;
                }
                else
                {
                    Console.WriteLine("!= no");
                    return false;
                }
            }
            public int getValue()
            {
                return id;
            }

            public override void SayName()
            {
                Console.WriteLine("First Name: " + firstName);
                Console.WriteLine("Last Name: " + lastName);
            }
            public void Quit()
            {
                Console.WriteLine("Quit.");
            }
        }
}
