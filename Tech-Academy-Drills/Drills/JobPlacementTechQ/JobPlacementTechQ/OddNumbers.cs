using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPlacementTechQ
{
    class OddNumbers
    {
        //Given an array of integers, write a method to total the odd numbers.
        static int getOdd(int[] arr, int arr_size)
        {
            int res = 0;
            for (int i = 0; i < arr_size; i++)
            {
                if ((int.Parse(arr[i].ToString()) % 2) != 0)
                    res++;
            }
            return res;

        }
        //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.
        static int getSum(int[] arr)
        {
            int sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
        
        //Given a string, reverse it.
        static string reverseString(string name)
        {
            char[] cArray = name.ToCharArray();
            string word = String.Empty;
            for(int j = cArray.Length - 1; j > -1; j--)
            {
                word += cArray[j];
            }
            return word;
        }

        //Given a string, remove any repeated letters.
        static string removeLetters(string name)
        {
            char[] cArray = name.ToCharArray();
            string word = String.Empty;
            foreach (var k in cArray)
            {
                if (word.Contains(k))
                    continue;
                else
                    word += k;
            }
            return word;
        }
        //FizzBuzz (Look this one up and try it out)
        static string FizzBuzz(int[] set)
        {
            
            string newSet = String.Empty;
            for (int w = 1; w <= 100; w++)
            {
                bool fizz = w % 3 == 0;
                bool buzz = w % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(w);
            }
            return newSet;
        }
        
        // Driver code 
        public static void Main()
        {
            int[] arr = { 2, 3, 5, 4, 5, 2, 4, 3, 2333, 77, 45, 44, 98, 45674544 };
            int n = arr.Length;

            Console.Write(getOdd(arr, n));
            Console.ReadLine();

            Console.Write(getSum(arr));
            Console.ReadLine();



            string name = "skyscrapper";
            Console.WriteLine(reverseString(name));
            Console.ReadLine();

            Console.WriteLine(removeLetters(name));
            Console.ReadLine();

            int[] set = {};
            Console.WriteLine(FizzBuzz(set));
            Console.ReadLine();

        }
        
     }

}









