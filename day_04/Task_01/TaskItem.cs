
using Enums;

namespace SimpleTaskManger
{
    public class TaskItem
    {

        public required string Name { get; set; }
        public required string Description { get; set; }
        public TaskType Category { get; set; }
        public bool IsCompleted { get; set; } = false;
        public override string ToString() {
            string CompletedStatus = IsCompleted ? "Completed" : "Not Completed";
            return $"{Name} {Description} {Category} {CompletedStatus}";
        }

    }
}