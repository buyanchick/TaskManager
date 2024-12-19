using TaskManager.Domain.Common;
using TaskManager.Domain.Models.TaskModels;

namespace TaskManager.Domain.Models.Task.Events
{
    public class TaskItemCompletedEvent : BaseEvent
    {
        public TaskItemCompletedEvent(TaskItem item)
        {
            Item = item;
        }

        public TaskItem Item { get; }
    }
}
