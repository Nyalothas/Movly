using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movly.Models;
using Movly.ViewModels;

namespace Movly.Controllers
{
    public class CustomersController : Controller
    {
        //private List<Customer> customers;
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer { Id =1, Name = "John Smith"},
        //        new Customer { Id =2, Name = "Amy White"}
        //    };
        //}

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers;
            //var viewModel = new CustomersViewModel
            //{
            //    Customers = customers
            //};

            return View(customers);
        }

        [Route ("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer != null)
                return View(customer);
            else
                return HttpNotFound();
        }
    }
}