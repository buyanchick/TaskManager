namespace TaskManager.Domain.Abstractions
{
    public interface ITaskManagerDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
