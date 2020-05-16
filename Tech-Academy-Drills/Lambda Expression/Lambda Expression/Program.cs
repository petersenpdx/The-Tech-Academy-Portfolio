using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. In the Main() method, create a list of at least 10 employees.Each employee should have a 
//first and last name, as well as an Id. At least two employees should have the first name "Joe".
//2. Using a foreach loop, create a new list of all employees with the first name "Joe".
//3. Do the same thing again, but this time with a lambda expression.
//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            list.Add(new Employee { firstName = "Joe", lastName = "Shmo", id = 2 });
            list.Add(new Employee { firstName = "John", lastName = "Trinidad", id = 7});
            list.Add(new Employee { firstName = "Laura", lastName = "Riley", id = 1, });
            list.Add(new Employee { firstName = "Derek", lastName = "Deeds", id = 9 });
            list.Add(new Employee { firstName = "Joe", lastName = "Lawrence", id = 6 });
            list.Add(new Employee { firstName = "Joe", lastName = "Rogan", id = 5 });
            list.Add(new Employee { firstName = "Erik", lastName = "The Red", id = 4 });

            List<Employee> joe = new List<Employee>();

            //************************ Number 2. **************************************
            foreach (Employee name in list)
            {
                if (name.firstName == "Joe")
                {
                    joe.Add(new Employee { firstName = name.firstName, lastName = name.lastName, id = name.id });
                }
            }

            foreach (Employee name in joe)
            {
                Console.WriteLine(name.firstName + " " + name.lastName + " " + name.id);
               
            }
            Console.ReadLine();
            //************************* Number 3. ******************************************

            List<Employee> lambdaJoe = list.Where(n => n.firstName == "Joe").ToList();
            
            foreach (Employee name in lambdaJoe)
            {
                Console.WriteLine(name.firstName + " " + name.lastName + " " + name.id);
            }
            Console.ReadLine();
            //*******************************Number 4. *************************************

            List<Employee> greaterThan = list.Where(x => x.id > 5).ToList();

            foreach (Employee name in greaterThan)
            {
                Console.WriteLine(name.firstName + " " + name.lastName + " " + name.id);
            }
            Console.ReadLine();
        }
    }

}
