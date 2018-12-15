using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EXERCISE: MATH AND COMPARISON OPERATORS
//Your job is to create an anonymous income comparison program.

//REQUIREMENTS
//The program must start by printing “Anonymous Income Comparison Program” to the screen.
//It must then print “Person 1” to the screen and get the following details:
//Hourly Rate
//Hours worked per week
//It must then print “Person 2” to the screen and then get the following details:
//Hourly rate
//Hours worked per week
//It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
//It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.
//It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.
namespace C_Sharp_Anonymous_Income_Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Anonymous Income Comparison Program
            //Person 1
            //Hourly Rate?
            //15
            //Hours worked per week?
            //40
            //Person 2
            //Hourly Rate?
            //20
            //Hours worked per week?
            //40
            //Weekly salary of Person 1:
            //600
            //Weekly salary of Person 2:
            //800
            //Does Person 1 make more money than Person 2 ?
            //false
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string Person1Hour = Console.ReadLine();
            double HourlyRate = Convert.ToDouble(Person1Hour);
            Console.WriteLine("Hours worked for the week?");
            string Person1HWeek = Console.ReadLine();
            int HoursWorked = Convert.ToInt32(Person1HWeek);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string Person2Hour = Console.ReadLine();
            double HourlyRate2 = Convert.ToDouble(Person2Hour);
            Console.WriteLine("Hours worked for the week?");
            string Person2HWeek = Console.ReadLine();
            int HoursWorked2 = Convert.ToInt32(Person2HWeek);

            Console.WriteLine("Weekly Salary Person 1:");
            double Person1Salery = HourlyRate * HoursWorked;
            Console.WriteLine(Person1Salery);
            Console.ReadLine();

            Console.WriteLine("Weekly Salary Person 2:");
            double Person2Salery = HourlyRate2 * HoursWorked2;
            Console.WriteLine(Person2Salery);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool TrueOrFalse = Person1Salery > Person2Salery;
            Console.WriteLine(TrueOrFalse);
            Console.ReadLine();

            Console.WriteLine("Annual Salary Person 1:");
            double Person1ASalery = (HourlyRate * HoursWorked)*52;
            Console.WriteLine(Person1ASalery);
            Console.ReadLine();

            Console.WriteLine("Weekly Salary Person 2:");
            double Person2ASalery = (HourlyRate2 * HoursWorked2)*52;
            Console.WriteLine(Person2ASalery);
            Console.ReadLine();
        }
    }
}
