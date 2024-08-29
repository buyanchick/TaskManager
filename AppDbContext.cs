using Microsoft.EntityFrameworkCore;

namespace TaskManager
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Task> Todos => Set<Task>();
    }
}
