using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo_Mvc.Models;

namespace Demo_Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
[HttpPost]
    public IActionResult Index(string FullName, string Address)
    {
        string strOutput = "Xin chào " + FullName + " đến từ " + Address;
        ViewBag.Massage = strOutput;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
