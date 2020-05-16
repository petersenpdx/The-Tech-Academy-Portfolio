using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("This is pretty cool.");
        }
    }
    
}
