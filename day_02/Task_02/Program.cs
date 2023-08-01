


using System.Runtime.InteropServices;

public class Program
{

    public static void Main()
    {
        Dictionary<string, int> map = GetWordFrequency("The Buick The Black and the blonds are the best and best.");
        foreach (var key in map.Keys)
        {
            if (map.TryGetValue(key, out var frequency))
                Console.WriteLine($"{key}: {frequency}");
        }
    }

    public static Dictionary<string, int> GetWordFrequency(string sentence)
    {
        Dictionary<string, int> freq = new();
        // split the sentence into words
        String[] words = sentence.Split(" ");

        foreach (string word in words)
        {
            if (freq.ContainsKey(word.ToLower()))
            {
                freq[word.ToLower()]++;
            }
            else
            {
                freq.Add(word.ToLower(), 1);
            }
        }

        return freq;
    }

}