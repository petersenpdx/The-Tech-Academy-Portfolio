using System;
using System.IO;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Ask a user for a number.
//2. Log that number to a text file.
//3. Print the text file back to the user.

namespace StreamWriter_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number. It will be logged and a text file stored in user log file.");
            string text = Console.ReadLine();
            File.WriteAllText("C:\\Users\\peter\\Log\\StreamWriterIO.txt", text);
            string fileRead = File.ReadAllText("C:\\Users\\peter\\Log\\StreamWriterIO.txt");
            Console.WriteLine("Statement logged: " + " " + fileRead);
            Console.ReadLine();
        }
    }
}
    