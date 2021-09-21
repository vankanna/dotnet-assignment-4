using Microsoft.AspNetCore.Mvc;
using assingment4.Models;
using System.Linq;

namespace assignment4
{
    public class ProductController : Controller
    {
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(category => category.CategoryName));
       
    }
}