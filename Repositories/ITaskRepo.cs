using TaskManager.Models;

namespace TaskManager.Repositories
{
    public interface ITaskRepo
    {
        Task<IEnumerable<Todo>> GetTasks();
    }
}
