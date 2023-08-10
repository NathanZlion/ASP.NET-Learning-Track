using Enums;
using CustomExceptions;

namespace SimpleTaskManger {
    public class Program {
        private readonly TaskManager taskManager = new TaskManager();

        public async void Start() {
            try {
                await taskManager.ReadDataFromFile();
            } catch (Exception e) {
                string errorMessage = $"Error running program : {e.Message}";
                Console.WriteLine(errorMessage);
                return;
            }
        }

        public static void PrintOptions() {
            Console.WriteLine(" Options ");
            Console.WriteLine("1. Add New Task");
            Console.WriteLine("2. View Tasks List");
            Console.WriteLine("3. View Task by Category");
            Console.WriteLine("4. Delete task");
            Console.WriteLine("5. Save And Exit");
        }


        public void HandleAddNewTask() {
            string inputFormat = $"name description category iscompleted";
            Console.WriteLine($"Input the new task info space separated like this: {inputFormat}");
            string[] input = Console.ReadLine()!.Split(" ");

            if (input.Length < 4) {
                throw new InvalidInputException();
            }

            try {
                string name = input[0];
                string description = input[1];
                TaskType category;
                if (!Enum.TryParse(input[2], true, out category))
                    throw new InvalidInputException();

                bool successParsingBool = bool.TryParse(input[3], out bool iscompleted);

                if (!successParsingBool) {
                    throw new InvalidInputException();
                }

                taskManager.AddTask(new TaskItem() {
                    Name = name,
                    Description = description,
                    Category = category,
                    IsCompleted = iscompleted
                });
            }

            catch (InvalidInputException exception) {
                Console.WriteLine($"Error, Invalid Input, Task not added, {exception.Message}");
            }

            catch (Exception exception) {
                Console.WriteLine($"Error, Task not added: {exception.Message}");
            }
        }

        public void HandleDeleteTask() {
            Console.WriteLine("Enter Task Name");
            string? taskName = Console.ReadLine();
            taskManager.DeleteTask(taskName!);
        }

        public void HandleViewTaskList() => taskManager.ViewTasks();

        public void HandleViewTaskByCategory() {
            Console.Write("Category (Personal/Work/Errands): ");
            if (Enum.TryParse(Console.ReadLine(), true, out TaskType filterCategory)){
                taskManager.ViewTasks(task => task.Category == filterCategory);
            }
            else
                Console.WriteLine("Invalid category.");
        }
    
        public async void HandleSaveAndExit() {
            try {
                await taskManager.WriteDataToFile();
            } catch (Exception e) {
                Console.WriteLine($"Error Saving: {e.Message}");
            }
        }

    }
}