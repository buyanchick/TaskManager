namespace Persistence
{
    public class DbInitializer
    {
        public static void Initialize(TaskManagerDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
