using TaskManager.Domain.Models.TaskModels;

namespace TaskManager.Domain.Abstractions.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetTasks();
        Task<TaskItem> GetTaskById(int taskId);
    }
}
