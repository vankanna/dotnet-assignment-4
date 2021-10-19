using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwindContext _northwindContext;
        public CustomerController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Index() => View(_northwindContext.Customers.OrderBy(customer => customer.CompanyName));

        public IActionResult Register() => View();
        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            // update student to the database
            if (_northwindContext.Customers.Any(c => c.CompanyName == customer.CompanyName))
            {
                ModelState.AddModelError("", "Company Name must be unique");
            }
            else
            {
                _northwindContext.AddCustomer(customer);
            }
            return RedirectToAction("Index");
        }
    }
}