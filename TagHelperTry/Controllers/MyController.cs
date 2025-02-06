using Microsoft.AspNetCore.Mvc;

namespace TagHelperTry.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
