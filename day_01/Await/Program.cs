

public class Program
{
    public static async Task Main()
    {
        int result = await Program.getNumber();
        Console.WriteLine(result);
    }

    static async Task<int> getNumber() {
        return 12;
    }
}
