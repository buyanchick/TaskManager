using TaskManager.Domain.Common;
using TaskManager.Domain.Models.Task.Events;

namespace TaskManager.Domain.Models.TaskModels
{
    public class TaskItem : BaseModel
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        private bool _isCompleted;
        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                if (value && !_isCompleted)
                {
                    AddDomainEvent(new TaskItemCompletedEvent(this));
                }

                _isCompleted = value;
            }
        }
    }
}
