using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

namespace Overload_Operator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee n1 = new Employee();
            Employee n2 = new Employee();

            n1.id = 18;
            n2.id = 18;

            bool yes = n1 == n2;
            bool no = n1 != n2;


            Employee human = new Employee();
            human.firstName = "Sample";
            human.lastName = "Student";
            human.SayName();

            IQuittable example = new Employee();
            example.Quit();


            Console.ReadLine();

        }
    }
}
