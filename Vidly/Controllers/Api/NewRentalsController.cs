using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using AutoMapper;
using Microsoft.Ajax.Utilities;
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

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (newRental.MovieIds.Count == 0)
                return BadRequest("No movie ids have been given");

            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == newRental.CustomerId);

            if (customer == null)
                return BadRequest("Customer id is not valid");

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();
              
            if (movies.Count != newRental.MovieIds.Count) 
                return BadRequest("On or more of the movie ids was invalid");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available (" + movie.Id + ")");

                movie.NumberAvailable--;

                var rental = new Rentals
                {
                    Customer = customer,
                    Movies = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }


    }
}