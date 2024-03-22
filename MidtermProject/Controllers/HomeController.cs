using Microsoft.AspNetCore.Mvc;
using MidtermProject.Models;
using System.Diagnostics;

namespace MidtermProject.Controllers
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
            List<string> Actlist = new List<string>();
            Actlist.Add("Eat");
            Actlist.Add("Study");
            Actlist.Add("Play");
            Actlist.Add("Sleep");
            ViewBag.myList = Actlist;

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
