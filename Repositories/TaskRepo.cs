
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Repositories
{
    public class TaskRepo : ITaskRepo
    {
        private readonly AppDbContext _context;

        public TaskRepo(AppDbContext context) {
            _context = context;
        }
        public async Task<IEnumerable<Todo>> GetTasks()
        {
            return await _context.Todos.ToListAsync();
        }
    }
}
