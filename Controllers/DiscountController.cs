using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
    public class DiscountController : Controller
    {
        private NorthwindContext _northwindContext;
        public DiscountController(NorthwindContext db) => _northwindContext = db;

        public ActionResult Index() => View(_northwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now));
    }
}