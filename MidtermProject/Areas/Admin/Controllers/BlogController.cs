using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MidtermProject.Models;

namespace MidtermProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        [BindProperty]
        public Blog Blog { get; set; }
        private readonly BlogDBContext dBContext;

        public BlogController(BlogDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Blog> lstBlogs = dBContext.Blogs.Include(b => b.Category).ToList();
            return View(lstBlogs);
        }

        public IActionResult Create()
        {
            Blog blog = new Blog();

            List<Category> categories = dBContext.Categories.ToList();
            ViewBag.Categories = categories;
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id)
        {
            if (ModelState.IsValid)
            {
                Blog.Category = dBContext.Categories.First(c => c.Id == Blog.CateId);
                dBContext.Blogs.Add(Blog);
                dBContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var postToDelete = dBContext.Blogs.FirstOrDefault(u => u.Id == id);
            if (postToDelete != null)
            {
                dBContext.Blogs.Remove(postToDelete);
                dBContext.SaveChanges(true);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
