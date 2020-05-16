using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quote.ViewModels;

namespace Quote.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (QuotesEntities db = new QuotesEntities())
            {;

                var quotes = db.Quotes;
                var quoteVms = new List<QuoteVm>();
                foreach (var Quotes in quoteVms)
                {

                    //var is named "Quotes" rather than "Quote" because the title
                    //of the edmx table couldn't be the same as the parameter "Quote".
                    var quoteVm = new QuoteVm();
                    quoteVm.Id = Quotes.Id;
                    quoteVm.Quote = Convert.ToDouble(Quotes.Quote);
                    quoteVm.FirstName = Quotes.FirstName;
                    quoteVm.LastName = Quotes.LastName;
                    quoteVm.EmailAddress = Quotes.EmailAddress;
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }
    }
}


