using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace MidtermProject.Models
{
    public class BlogDBContext:  DbContext
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set;}
        public DbSet<Category> Categories { get; set;}
    }
}
