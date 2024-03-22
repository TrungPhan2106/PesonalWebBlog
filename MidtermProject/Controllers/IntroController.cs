using Microsoft.AspNetCore.Mvc;

namespace MidtermProject.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
