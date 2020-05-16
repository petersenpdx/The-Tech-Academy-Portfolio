using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//Concatenate three strings.
//Convert a string to uppercase.
//Create a Stringbuilder and build a paragraph of text, one sentence at a time.

namespace C_Sharp_Concatenate___StringBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is \t" + "Mark Petersen \n" + "And this is my code");
            Console.ReadLine();

            string name = "this is now in upper case";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");
            sb.AppendLine("And another one!");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
