using System;
using System.Collections.Generic;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Create an array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.
//2. Create an array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.
//3. Add in a message that displays when the user selects an index that doesn’t exist.
//4. Create a List of strings.Ask the user to select an index of the List and then display the content at that index on the screen.



    class Program
    {
        static void Main()
        {
           string[] stringArray = new string[4];
            stringArray[0] = "Dog";
            stringArray[1] = "Cat";
           stringArray[2] = "Mouse";
            stringArray[3] = "Chicken";

        Console.WriteLine("Select an index of the Anaimal Array (0-3)");
        int index = Convert.ToInt16(Console.ReadLine());

        if (3 >= index)
        {
            Console.WriteLine("The animal you chose from the index is:" + stringArray[index]);
            Console.ReadLine();
        }
        else
            {
            Console.WriteLine("Index number does not exist.");
            Console.ReadLine();

        }
            
            
        int[] numArray1 = new int[] { 3, 4, 10, 243 };
            Console.WriteLine("Select an index of the Number Array (0-3)");
            int index1 = Convert.ToInt16(Console.ReadLine());

        if (3 >= index1)
        {
            Console.WriteLine("The number you chose from the index is:" + numArray1[index1]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Index number does not exist.");
            Console.ReadLine();
        }

        List<string> intList = new List<string>();
        intList.Add("Hello World!");
        intList.Add("Hello User!");
        intList.Add("Hello Program!");
        intList.Add("Hello Flynn...");

        Console.WriteLine("Select an index of the list (0-3)");
        int list = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("You said" + intList[list]);
        Console.ReadLine();
    }
}
