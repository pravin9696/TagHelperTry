using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using TagHelperTry.Models;

namespace TagHelperTry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Languages> langs = new List<Languages>()
            { 
              new Languages(){ID="101", Lang="English"},
              new Languages(){ID="102", Lang="Hindi"},
              new Languages(){ID="103", Lang="Marathi"},
            };
            var langlist = new SelectList(langs, "ID", "Lang","103");
            ViewBag.Languages = langlist;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Languages lag)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
