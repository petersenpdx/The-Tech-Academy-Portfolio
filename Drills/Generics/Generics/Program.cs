using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Make the Employee class take a generic type parameter.
//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
//3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
//4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
//5. Create a loop that prints all of the Things to the Console.

namespace Generics
{
    class Program
    {
                static void Main(string[] args)
            {
                Employee<string> sports = new Employee<string>();
                sports.Things = new List<string>() { "soccer", "football", "hockey", "tennis", "basketball" };

                foreach (string item in sports.Things)
                {
                    Console.WriteLine(item);
                }
                Employee<int> numbers = new Employee<int>();
                numbers.Things = new List<int>() { 1, 2, 3, 4, 5 };

                foreach (int num in numbers.Things)
                {
                    Console.WriteLine(num);
                }
                Console.ReadLine();

            }
        
    }
}
