using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Person
    {
        
        public string firstName;
        public string lastName;

        public void SayName()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
        }
    }
}

