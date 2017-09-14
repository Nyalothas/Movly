using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movly.Models;
using Movly.ViewModels;

namespace Movly.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> movies;
        public MoviesController()
        {
            movies = new List<Movie>
            {
                new Movie { Name = "best 1"},
                new Movie { Name = "second 2"}
            };
        }
        // GET: Movies
        public ActionResult Index()
        {
            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };
            return View(viewModel);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Movie1", Id = 1 };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Hello World Text");
            //return HttpNotFound(); //returns 404
            //return new EmptyResult(); //returns nothing
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"}); //Action , Controller, arguments
        }

        // GET: Movies/Edit
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        [Route("movies/release/{year}/{month:regex(\\d{2}:range(1,12))}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        // GET: Movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}