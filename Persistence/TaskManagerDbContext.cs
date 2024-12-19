using System.Reflection;
using TaskManager.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Models.TaskModels;

namespace Persistence
{
    public class TaskManagerDbContext: DbContext, ITaskManagerDbContext
    { 
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) : base(options) { }

        public DbSet<TaskList> TodoLists => Set<TaskList>();
        public DbSet<TaskItem> TodoItems => Set<TaskItem>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
