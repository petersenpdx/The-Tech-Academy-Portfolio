using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quote.Models
{
    public class CarQuote
    {
        public int currentPrice { get; set; }
        public int totalPrice { get; set; }

        public static void CalculateQuote(Insuree Quotes, out int totalPrice)
        {
            int currentPrice = 50;

            if (DateTime.Now.Year - Quotes.DateOfBirth.Year < 25 && DateTime.Now.Year - Quotes.DateOfBirth.Year > 18
                && DateTime.Now.Year - Quotes.DateOfBirth.Year < 100)
            {
                currentPrice += 25;
            }
            if (DateTime.Now.Year - Quotes.DateOfBirth.Year < 18)
            {
                currentPrice += 100;
            }
            if (DateTime.Now.Year - Quotes.DateOfBirth.Year > 100)
            {
                currentPrice += 25;
            }

            if (Quotes.CarYear < 2000)
            {
                currentPrice += 25;
            }
            if (Quotes.CarYear > 2015)
            {
                currentPrice += 25;
            }

            string lowerCarMake = Quotes.CarMake.ToLower();
            string lowerCarModel = Quotes.CarModel.ToLower();
            if (lowerCarMake == "porsche" && lowerCarModel != "911 carrera")
            {
                currentPrice += 25;
            }
            if (lowerCarMake == "porsche" && lowerCarModel == "911 carrera")
            {
                currentPrice += 50;
            }

            for (int i = 0; i < Quotes.SpeedingTickets; i++)
            {
                if (i != Quotes.SpeedingTickets)
                {
                    currentPrice += 10;
                }
            }

            if (Quotes.DUI == true)
            {
                currentPrice += (currentPrice / 4);
            }

            if (Quotes.CoverageType == true)
            {
                currentPrice += (currentPrice / 2);
            }

            totalPrice = currentPrice;
        }
    }
}