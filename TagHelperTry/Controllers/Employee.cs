using Microsoft.AspNetCore.Mvc;
using TagHelperTry.Models;

namespace TagHelperTry.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Employee1 emp)
        {
            return View();
        }
    }
}
