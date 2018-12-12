using System;
using System.Collections.Generic;


//EXERCISE:
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Create a list of integers.Ask the user for a number to divide each number in the list by.Write a loop that 
//    takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
//    2. Run that code, entering in non-zero numbers as the user.Look at the displayed results.
//    3. Run that code, entering in zero as the number to divide by.Note any error messages you get.
//    4. Run that code, entering in a string as the number to divide by.Note any error messages you get.
//    5. Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program display 
//    a message to the display to let you know the program has emerged from the try/catch block and continued on with 
//    program execution.In the catch block, display the error message to the screen.Then try various combinations of user 
//    input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code 
//    after the try/catch block gets executed.



class Program
{
        static void Main(string[] args)
        {
        try
        {
            List<int> data = new List<int>() { 5, 7, 26, 4, 5, 1, 70, 30, 22, 14, 16, 18 };

            Console.WriteLine("Pick a number for the program to devide each number on the list.");
            int number = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < data.Count; i++)

            {
                int result = data[i] / number;
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Pelase type a whole number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't deive by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
        }
}
