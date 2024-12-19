using TaskManager.Domain.Common;

namespace TaskManager.Domain.Models.TaskModels
{
    public class TaskList : BaseModel
    {
        public string? Title { get; set; }
        public IList<TaskItem> Items { get; private set; } = new List<TaskItem>();
    }
}
