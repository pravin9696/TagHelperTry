using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TagHelperTry.Models;

namespace TagHelperTry.Controllers
{
    public class PracticeController : Controller
    {
        public IActionResult Index()
        {
             List<SelectListItem> langs=new List<SelectListItem>() { 
            new SelectListItem{Text="C language",Value="C"},
            new SelectListItem{Text="CPP language",Value="C++"},
            new SelectListItem{Text="JAVA",Value="JAVA"},
            new SelectListItem{Text="C#",Value="C#"},
             };
            ViewBag.langs=langs;
            Languages lg = new Languages() { ID = "111", Lang = "Select Language" };
            return View(lg);
        }
        [HttpPost]
        public IActionResult Index(Languages lg)
        {
            return View();
        }
        public IActionResult ShowLangs()
        {
            List<Languages> langs=new List<Languages>() 
            {
                new Languages{ID="1",Lang="Marathi"},
                new Languages{ID="2",Lang="Hindi"},
                new Languages{ID="3",Lang="English"},
            };
            ViewBag.langs = new SelectList(langs, "ID", "Lang", "1");
            return View();  
        }
        [HttpPost]
        public IActionResult ShowLangs(Languages lg)
        {
            return View();
        }
        }
}
