using System;
using Functions;


class Program
{
    static int Main(string[] args)
    {

        if (args.Length == 0)
        {
            Console.WriteLine("Please enter an argument. Usage: dotnet run <num>");
            return 1;
        }

        bool success = int.TryParse(args[0], out int input);

        if (!success)
        {
            Console.WriteLine("Please enter a numberic input");
            return 1;
        }

        long result = Func.GetFactorial(input);
        Console.WriteLine($"Factorial of {input} is {result}");
        return 0;
    }
}
