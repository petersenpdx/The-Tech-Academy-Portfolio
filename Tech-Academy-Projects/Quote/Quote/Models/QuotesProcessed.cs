using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quote.Models
{
    public class QuotesProcessed
        {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public Nullable<bool> DUI { get; set; }
        public Nullable<int> SpeedingTickets { get; set; }
        public Nullable<bool> CoverageType { get; set; }
        public Nullable<int> FinalQuote { get; set; }
    }
}