using Microsoft.AspNetCore.Mvc;
using MidtermProject.Models;

namespace MidtermProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        [BindProperty]
        public Category Category { get; set; }
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

        public IActionResult Create()
        {
            Category category = new Category();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id)
        {
            if (ModelState.IsValid)
            {
                dBContext.Add(Category);
                dBContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var postToDelete = dBContext.Categories.FirstOrDefault(u => u.Id == id);
            if (postToDelete != null)
            {
                dBContext.Categories.Remove(postToDelete);
                dBContext.SaveChanges(true);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
