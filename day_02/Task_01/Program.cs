
using System;

public class Program
{
    private static void Main(string[] args)
    {
        // Prompt user for name input
        Console.Write("Enter your name: ");
        string? student_name = Console.ReadLine();

        // Prompt user for the number of subjects taken
        Console.Write("Enter the number of subjects taken: ");
        int number_of_subjects = int.Parse(Console.ReadLine()!);

        // Create a list of subjects
        List<Subject> subjects = new();

        Console.WriteLine("Enter Information About Subjects Below: \n\n");

        // Prompt user for subject name and points
        for (int i = 1; i <= number_of_subjects; i++)
        {
            Console.Write($"{i}. Enter subject name: ");
            string? subjectName = Console.ReadLine();

            Console.Write($"{i}. Enter subject points: ");

            double subjectPoints;

            while (true)
            {
                bool validDouble = double.TryParse(Console.ReadLine(), out subjectPoints);
                if (!validDouble)
                {
                    Console.WriteLine("Please enter a valid Integer value. \n :-");
                    continue;
                }

                if (!UtilMethods.IsValidPoint(subjectPoints))
                {
                    Console.WriteLine("Please enter a value between 0 and 100.\n :-");
                    continue;
                }
                break;
            }
            subjects.Add(new Subject(subjectName!, subjectPoints));
            Console.WriteLine("______________________________");
        }


        Console.WriteLine("______________________________");
        Console.WriteLine($"Name: {student_name}");
        Console.WriteLine($"Taken: {number_of_subjects} Subjects");
        Console.WriteLine("______________________________");

        double total = 0.0;
        int count = 1;

        foreach (Subject subject in subjects)
        {
            Console.WriteLine($"{count}, Name: {subject.Name}.. Point: {subject.Points}..Grade:{UtilMethods.GetGrade(subject.Points)}");
            total += subject.Points;
            count++;
        }

        double average = total / subjects.Count;

        Console.WriteLine($"\n>> Average points: {average}%");
        Console.WriteLine($">> Average Grade: {UtilMethods.GetGrade(average)}\n");

        Console.ReadLine();  // keep console open to be seen.
    }
}

