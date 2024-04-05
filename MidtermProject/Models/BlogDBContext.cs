using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using MidtermProject.Models;

namespace MidtermProject.Models
{
    public class BlogDBContext:  IdentityDbContext<AppUser>
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set;}
        public DbSet<Category> Categories { get; set;}
        public DbSet<MidtermProject.Models.User> User { get; set; } = default!;
        public DbSet<MidtermProject.Models.Login> Login { get; set; } = default!;
    }
}
