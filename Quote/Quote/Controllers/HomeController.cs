using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quote.ViewModels;
using Quote.Models;

namespace Quote.Controllers
{
    public class HomeController : Controller
    {
        //private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessQuote(string firstName, string lastName, string emailAddress,
            DateTime dateOfBirth, int carYear, string carMake, string carModel,
            bool? DUI, int speedingTickets, bool? coverageType)
        {
            using (QuotesEntities db = new QuotesEntities())
            {
                var Quotes = new Insuree();

                Quotes.FirstName = firstName;
                Quotes.LastName = lastName;
                Quotes.EmailAddress = emailAddress;
                Quotes.DateOfBirth = dateOfBirth;
                Quotes.CarYear = carYear;
                Quotes.CarMake = carMake;
                Quotes.CarModel = carModel;

                if (Request.Form["DUI"] == "Yes")
                {
                    Quotes.DUI = true;
                }
                else
                {
                    Quotes.DUI = false;
                }

                Quotes.SpeedingTickets = speedingTickets;

                if (Request.Form["CoverageType"] == "Full Coverage")
                {
                   Quotes.CoverageType = true;
                }
                else
                {
                    Quotes.CoverageType= false;
                }

                db.Insurees.Add(Quotes);
                db.SaveChanges();

                var quoteProcessed = new QuotesProcessed();
                var quotesProcessed = new List<QuotesProcessed>();
                int finalQuote = 50;
                CarQuote.CalculateQuote(Quotes, out finalQuote);

                quoteProcessed.FirstName = Quotes.FirstName;
                quoteProcessed.LastName = Quotes.LastName;
                quoteProcessed.EmailAddress = Quotes.EmailAddress;
                quoteProcessed.DateOfBirth = Quotes.DateOfBirth;
                quoteProcessed.CarYear = Quotes.CarYear;
                quoteProcessed.CarMake = Quotes.CarMake;
                quoteProcessed.CarModel = Quotes.CarModel;
                quoteProcessed.DUI = Quotes.DUI;
                quoteProcessed.SpeedingTickets = Quotes.SpeedingTickets;
                quoteProcessed.CoverageType = Quotes.CoverageType;
                quoteProcessed.FinalQuote = finalQuote;

                quotesProcessed.Add(quoteProcessed);

                return View("YourQuote", quotesProcessed);
            }
        }

    }
}