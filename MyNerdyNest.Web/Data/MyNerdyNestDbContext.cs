using Microsoft.EntityFrameworkCore;
using MyNerdyNest.Web.Models.Domain;

namespace MyNerdyNest.Web.Data
{
    public class MyNerdyNestDbContext : DbContext
    {
        public MyNerdyNestDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
