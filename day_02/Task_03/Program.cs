using System.Text.RegularExpressions;


public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n Input a string: ");
            string? input = Console.ReadLine();

            if (input == ""){
                break;
            }

            input = RemovePunctuation(input);

            if (!IsPalindrome(word: input))
            {
                Console.WriteLine($"> NO: {input} is not palindrome");
            }
            else
            {
                Console.WriteLine($"> YES: {input} is palindrome");
            }
        }
    }

    static string RemovePunctuation(string input)
    {
        string pattern = @"\p{P}";
        string result = Regex.Replace(input, pattern, "");
        return result;
    }

    public static bool IsPalindrome(string word)
    {
        if (word.Length == 0)
            return false;
        char[] chars = word.ToCharArray();
        int charsLength = chars.Length;

        for (int i = 0; i < chars.Length / 2; i++)
        {
            if (chars[i] != chars[charsLength - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}