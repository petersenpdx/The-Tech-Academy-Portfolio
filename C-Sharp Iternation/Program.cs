using System;
using System.Collections.Generic;

//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Create a one-dimensional Array of strings.Ask the user to input some text. 
//Create a loop that goes through each string in the Array, adding the user’s text to the string.
//Then create a loop that prints off each string in the Array on a separate line.

//2. Create an infinite loop.
//3. Fix the infinite loop so it will execute.

//4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
//5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

//6. Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.
//Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
//7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
//8. Add code to that above loop that stops it from executing once a match has been found.

//9. Create a List of strings that has at least two identical strings in the List. Ask the user to select 
//text to search for in the List. Create a loop that iterates through the list and then displays the 
// the indices of the array that contain matching text on the screen.
//10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
//11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates 
//each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

class Program
{
    
    static void Main(string[] args)
    {
        //**************************************************EXCERSIZE 1.***************************************************
        //Console.WriteLine("Enter first fruit name");
        //string addf1 = Console.ReadLine();

        //Console.WriteLine("Enter second fruit name");
        //string addf2 = Console.ReadLine();

        //Console.WriteLine("Enter third fruit name");
        //string addf3 = Console.ReadLine();

        //Console.WriteLine("Enter final fruit name");
        //string addf4 = Console.ReadLine();

        //string[] fruit = { addf1, addf2, addf3, addf4 };

        //for (int j = 0; j < fruit.Length; j++)

        //{
        //    Console.WriteLine(fruit[j]);

        //}
        //Console.ReadLine();

        //***********************************EXERCIZE 2. & 3.****************************************************

        //int[] data = { 5, 7, 26, 4, 5, 1, 70, 30, 22, 14, 16, 18 };

        //for (int i = 0; i < data.Length; i++)
        //{
        //    if (data[i] <= 5 || 25 < data[i])
        //    {
        //        Console.WriteLine("Data is out of Spec: " + data[i]);
        //    }

        //}
        //Console.ReadLine();

        //****************************** EXERCISE 4. & 5.***************************************************

        //int[] guess = { 2, 3, 4, 5, 6, 10 };

        //for (int i = 0; ;)
        //{
        //    Console.WriteLine(guess[0]);
        //    Console.ReadLine();
        //}


        ////**************************************************EXERCIZE 6., 7. & 8.********************************************
        //List<string> planets = new List<string>() {"Mars", "Jupiter","Venus", "Neptune"} ;

        //Console.WriteLine("Select a planet to look for in the index");
        //string selected = Console.ReadLine();

        //for (int k = 0; k < 4; k++)
        //{
        //    if (selected == planets[k])
        //    {
        //       Console.WriteLine(k);
        //       Console.ReadLine();
        //       break;

        //    }
        //    else
        //    {
        //        Console.WriteLine("This planet can not be found in the index");
        //        Console.ReadLine();
        //    }
        //}


        //  ***************************************************** EXERCISE 9. & 10.********************************************
        //List<string> metals = new List<string>() { "Gold", "Silver", "Platnuim", "Titanuim", "Gold", "Iron", "Iron" };

        //Console.WriteLine("Select a metal to look for in the index");
        //string select = Console.ReadLine();



        //for (int q = 0; q < 7; q++)
        //{
        //    if (select == metals[q])
        //    {
        //        Console.WriteLine(q);
        //        Console.ReadLine();


        //    }
        //    else
        //    {
        //        Console.WriteLine("This metal can not be found in the index.");

        //        Console.ReadLine();
        //        continue;
        //    }

        //    }
        //Console.WriteLine("Do you wish to add any metals to the list?");
        //string YesNo = Console.ReadLine();
        //if (YesNo == "Yes")
        //{
        //    Console.WriteLine("Please enter the metal you wish to add:");
        //    string metalAdd = Console.ReadLine();
        //    metals.Add(metalAdd);
        //    for (int q = 0; q < metals.Count; q++)
        //    {

        //        Console.WriteLine(metals[q]);

        //    }
        //    Console.ReadLine();
        //}
        //else
        //{
        //    Console.WriteLine("Thank you and have a good day.");
        //    Console.ReadLine();

        //}

        //************************************************************EXERCIZE 11. *******************************************************
        List<string> clothes = new List<string>() { "Nike", "Pendleton", "Nike", "Adidas", "Patagonia", "Fjallraven", "Fjallraven" };

        foreach (string cloth in clothes)
           
        {
            Console.WriteLine(cloth);
            Console.ReadLine();
            //if (cloth < 2)
            //{
            //    Console.WriteLine(cloth);
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("This metal can not be found in the index.");
            //    Console.ReadLine();
            //    continue;
            //}
        }
       
    }
}
    

