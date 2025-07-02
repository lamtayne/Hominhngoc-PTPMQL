using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace Demo_Mvc.Controllers
{
    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "Hồ Minh Ngọc 2121050319";
        }
    }
}