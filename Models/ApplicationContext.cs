using Microsoft.EntityFrameworkCore;

namespace PR_16_1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
