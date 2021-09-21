using Microsoft.AspNetCore.Mvc;
using assingment4.Models;
using System.Linq;

namespace assingment4.Controllers
{
    public class HomeController : Controller
    {
        private NorthwindContext _northwindContext;
        public HomeController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Index() => View();
    }
}