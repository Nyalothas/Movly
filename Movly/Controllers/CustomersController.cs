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
        private List<Customer> customers;
        public CustomersController()
        {
            customers = new List<Customer>
            {
                new Customer { Name = "John Smith"},
                new Customer { Name = "Amy White"}
            };
        }

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route ("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            if (id != 0 && id <= customers.Count())
                return View(customers[--id]);
            else
                return HttpNotFound();
        }
    }
}