namespace TaskManager.Repositories
{
    public interface ITaskRepo
    {
        Task<IEnumerable<Task>> GetTasks();
    }
}
