using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectQRapps.Models;

namespace ProjectQRapps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;// ServiceCollection injects Ilogger ? dont know what it does 

        public HomeController(ILogger<HomeController> logger)// Must have contructor to inject 
        {
            _logger = logger;
        }

        //index page 
        public IActionResult Index()
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
