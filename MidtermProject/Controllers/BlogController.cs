using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MidtermProject.Models;

namespace MidtermProject.Controllers
{
    public class BlogController : Controller
    {
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
    }
}
