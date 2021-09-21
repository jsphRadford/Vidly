using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST: Rentals
        public ActionResult New()
        {
            return View();
        }

        //GET Rentals
        public ActionResult Returns()
        {
            var rentals = _context.Rentals.

            return View(rentals);
        }




    }
}