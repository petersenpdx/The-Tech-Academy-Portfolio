using CarInsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities2 _db = new InsuranceEntities2();


        Insuree c = new Insuree();

        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Insurees.ToList());
        }

        // ADMIN page
        public ActionResult Admin()
        {
            return View(_db.Insurees.ToList());
        }

        // CD: built nav to success
        public ActionResult Success()
        {
            return View(_db.Insurees.OrderByDescending(x => x.QuoteTotal).Take(1).ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Insuree carToCreate)
        {
            if (!ModelState.IsValid)
                return View();

            SetProps(carToCreate); // CD: ensure props are set
            carToCreate.QuoteTotal = Quote(); // CD: set gen'd quote

            _db.Insurees.Add(carToCreate);
            _db.SaveChanges();

            return View("Success", _db.Insurees.OrderByDescending(x => x.QuoteTotal).Take(1).ToList()); // CD nav to success
            //return RedirectToAction("Index"); // CD removed

        }

        private void SetProps(Insuree carToCreate)
        {
            throw new NotImplementedException();
        }



        //Function to create Quote Calculation
        decimal quoteTotal = 50; // put in global

        public decimal Quote()
        {
            if (DateTime.Now.Year - c.DateOfBirth.Year > 25)
            {
                quoteTotal = quoteTotal + 25;
            }
            if (DateTime.Now.Year - c.DateOfBirth.Year < 18)
            {
                quoteTotal = quoteTotal + 100;
            }
            if (DateTime.Now.Year - c.DateOfBirth.Year > 100)
            {
                quoteTotal = quoteTotal + 25;
            }

            if (c.CarYear < 2000)
            {
                quoteTotal = quoteTotal + 25;
            }
            if (c.CarYear > 2015)
            {
                quoteTotal = quoteTotal + 25;
            }
            if (c.CarMake.ToLower() == "porsche")
            {
                quoteTotal = quoteTotal + 25;
            }
            if (c.CarMake.ToLower() == "porsche" && c.CarModel.ToLower() == "911 carrera")
            {
                quoteTotal = quoteTotal + 25;
            }
            if (c.SpeedingTickets > 4)
            {
                quoteTotal = quoteTotal + (c.SpeedingTickets * 10);
            }
            if (c.DUI == true)
            {
                quoteTotal = quoteTotal + (Decimal.Multiply(quoteTotal, .25M));
            }
            if (c.CoverageType == true) // CD: fixed issue with calc on full (was converting ToLower() but comapring to Full)
            {
                quoteTotal = quoteTotal + (Decimal.Multiply(quoteTotal, .25M));
            }

            return quoteTotal; // CD return val
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var carToEdit = (from c in _db.Insurees
                             where c.Id == id
                             select c).First();

            return View(carToEdit);
        }



        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Insuree carToEdit)
        {
            var originalCar = (from c in _db.Insurees
                               where c.Id == carToEdit.Id
                               select c).First();
            if (!ModelState.IsValid)
                return View(originalCar);

            _db.Entry(originalCar).CurrentValues.SetValues(carToEdit);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            Insuree deletedCar = _db.Insurees.Find(id);
            if (deletedCar == null)
            {
                return HttpNotFound();
            }
            return View(deletedCar);


        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree deletedCar = _db.Insurees.Find(id);
            _db.Insurees.Remove(deletedCar);
            _db.SaveChanges();



            return RedirectToAction("Index");



        }
    }
}