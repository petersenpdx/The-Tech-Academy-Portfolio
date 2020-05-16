using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//REQUIREMENTS
//Ask the following questions:

//What is your age?

//Have you ever had a DUI?

//How many speeding tickets do you have?

//Use the following qualification rules to determine if the applicant qualifies for car insurance:

//Applicants must be over 15 years old.

//Applicants must not have any DUI’s.

//Applicants must not have more than 3 speeding tickets.

//Print the result of the boolean expression created from the above business rules.

namespace C_Sharp_Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //            What is your age ?
            //32
            //Have you ever had a DUI ?
            //false
            //How many speeding tickets do you have?
            //1
            //Qualified ?
            //

            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            int AgeInt = Convert.ToInt16(Age);
            
            Console.WriteLine("Have you ever had a DUI before (answer True/False)?");
            string DUI = Console.ReadLine();
           

            Console.WriteLine("How many spending tickets do you have?");
            string Tickets = Console.ReadLine();
            int SpeedingTickets = Convert.ToInt16(Tickets);
            
            Console.WriteLine("Qualified?");
            Console.WriteLine(AgeInt > 15 && DUI =="True" && SpeedingTickets <= 3);
            Console.ReadLine();


        }
    }
}
