using Enums;

namespace SimpleTaskManger
{
    public class TaskManager
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private const string pathToFile = "data.csv";

        public void AddTask(TaskItem task) => tasks.Add(task);
        

        public void ViewTasks(Func<TaskItem, bool> filter = null) {
            var filteredTasks = filter != null ? tasks.Where(filter) : tasks;

            if (!filteredTasks.Any()) {
                Console.WriteLine("No tasks found.");
                return;
            }

            foreach (var task in filteredTasks)
                Console.WriteLine(task);
        }

        public void DeleteTask(string taskName) {
            tasks = tasks.Where(task => !task.Name.Equals(taskName)).ToList();
        }

        public async Task ReadDataFromFile()
        {
            if (!File.Exists(pathToFile))
                return;

            using (StreamReader reader = new StreamReader(pathToFile))
            {
                while (true)
                {
                    string? line = await reader.ReadLineAsync();
                    if (line == null)
                        break;

                    string[] parts = line.Split(',');

                    if (parts.Length == 4)
                    {
                        TaskItem task = new TaskItem
                        {
                            Name = parts[0],
                            Description = parts[1],
                            Category = (TaskType)Enum.Parse(typeof(TaskType), parts[2], true),
                            IsCompleted = bool.Parse(parts[3])
                        };
                        tasks.Add(task);
                    }
                }
            }
        }

        public async Task WriteDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(pathToFile))
            {
                foreach (TaskItem task in tasks)
                {
                    await writer.WriteLineAsync($"{task.Name},{task.Description},{task.Category},{task.IsCompleted}");
                }
            }
        }

    }
}