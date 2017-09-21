using Movly.Dtos;
using Movly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Movly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST /api/NewRentals
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto  newRentalDto)
        {
            //load customer and movies based on the id the dto gives
            //for each movie create a new rental object
            //then add it to the database

            if (newRentalDto.MovieIds.Count == 0)
                return BadRequest("No Movies have been given.");

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == newRentalDto.CustomerId);

            if (customerInDb == null)
                return BadRequest("Customer does not exist.");

            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRentalDto.MovieIds.Count)
                return BadRequest("One or more Movies are invalid.");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;
                var rentedRecord = new Rental()
                {
                    Customer = customerInDb,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rentedRecord);
            }

            _context.SaveChanges();
            return Ok();
        }

        // GET /api/NewRentals
        public IHttpActionResult GetRentals(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            var rentedMoviesByCustomer = _context.Rentals
                .Select(r => r.Customer.Id == customerInDb.Id).ToList();

            return Ok(rentedMoviesByCustomer);
        }
    }
}
