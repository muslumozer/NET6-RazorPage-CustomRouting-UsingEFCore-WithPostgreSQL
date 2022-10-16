using Microsoft.EntityFrameworkCore;

namespace NET6RazorPageCustomRoutingUsingEFCoreWithPostgreSQL.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
