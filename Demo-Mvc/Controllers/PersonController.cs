using Microsoft.AspNetCore.Mvc;
using Demo_Mvc.Models;
using DemoMVC.Models; 

namespace Demo_Mvc.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chào " + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }
}
