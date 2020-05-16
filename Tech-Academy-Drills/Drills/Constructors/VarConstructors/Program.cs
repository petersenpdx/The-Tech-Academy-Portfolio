using System;

//EXERCISE:
//1. Create a const variable
//2. Create a variable using the keyword "var".
//3. Chain two constructors together.

namespace VarConstuctors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Mark Petersen";
            Console.WriteLine("Hello! My name is {0}.", myName);
            
            Console.Write("What is your first name?");
            var first = Console.ReadLine();
            Console.Write("What is your last name?");
            var last = Console.ReadLine();

            Constructor name = new Constructor(first, last);
            Console.WriteLine("Your name is {0} {1}.", first, last);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Have a great day!");
            Console.ReadLine();
        }
    }
}