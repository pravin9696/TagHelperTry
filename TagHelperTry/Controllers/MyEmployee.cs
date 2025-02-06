using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using TagHelperTry.Models;

namespace TagHelperTry.Controllers
{
    public class MyEmployee : Controller
    {
        public IActionResult Index()
        {
            List<Departments> depts= new List<Departments>() {
               new Departments(){deptid=100,name="sales"},
               new Departments(){deptid=101,name="Account"},
               new Departments(){deptid=102,name="HR"},

            };
            SelectList deptList=new SelectList(depts,"deptid","name");
            ViewBag.deptList = deptList;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee3 emp)
        {
            if (ModelState.IsValid)
            {
                //CRUD operation
                return View();
            }
            else
            {           
            List<Departments> depts = new List<Departments>() {
               new Departments(){deptid=100,name="sales"},
               new Departments(){deptid=101,name="Account"},
               new Departments(){deptid=102,name="HR"},

            };
            SelectList deptList = new SelectList(depts, "deptid", "name");
            ViewBag.deptList = deptList;
            return View();
            }
        }
    }
}
