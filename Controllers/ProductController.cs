using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind
{
    public class ProductController : Controller
    {
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(category => category.CategoryName));
        public IActionResult Index(int id) => View(_northwindContext.Products.Where(product => product.CategoryId == id && product.Discontinued == false).OrderBy(product => product.ProductName));
    }
}