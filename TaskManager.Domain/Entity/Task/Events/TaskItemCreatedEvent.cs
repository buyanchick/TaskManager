using TaskManager.Domain.Common;
using TaskManager.Domain.Models.TaskModels;

namespace TaskManager.Domain.Models.Task.Events
{
    public class TaskItemCreatedEvent : BaseEvent
    {
        public TaskItemCreatedEvent(TaskItem item)
        {
            Item = item;
        }

        public TaskItem Item { get; }
    }
}
