using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/rental/
        public IHttpActionResult GetRentals()
        {
            var rentals = _context.Rentals.Where(c => c.DateReturned == null).ToList();


            var rentalDtos = rentals.ToList().Select(Mapper.Map<Rental, NewRentalDto>);

            return Ok(rentalDtos);
        }


        //POST /api/rental/
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customer.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movie.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();
            
            
            foreach (var movie in movies)
            {
                if (movie.NumberAvaliable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvaliable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();

        }

    }
}
