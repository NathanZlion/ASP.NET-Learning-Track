namespace SimpleTaskManger
{
    public class MainProgram
    {
        public static void Main()
        {
            var program = new Program();
            try {
                program.Start();
            } catch {
                return;
            }
            while (true)
            {
                Program.PrintOptions();

                bool InputIsSane = int.TryParse(Console.ReadLine(), out int Choice);

                if (!InputIsSane | Choice <= 0 && Choice > 5)
                {
                    Console.WriteLine("Choose wisely, as if your life depends on it");
                    continue;
                }

                if (Choice == 1)
                    program.HandleAddNewTask();

                else if (Choice == 2)
                    program.HandleViewTaskList();

                else if (Choice == 3)
                    program.HandleViewTaskByCategory();

                else if (Choice == 4)
                    program.HandleDeleteTask();

                else if (Choice == 5) {
                    program.HandleSaveAndExit();
                    break;
                }
            }
        }
    }
}