using Microsoft.AspNetCore.Mvc;
using MidtermProject.Models;

namespace MidtermProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BlogDBContext dBContext;

        public CategoryController(BlogDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = dBContext.Categories.ToList();
            return View(categories);
        }
    }
}
