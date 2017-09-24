using System;
using System.Collections.Generic;
using System.Linq;

class SplitbyWordCasing
{
    static void Main()
    {
        List<string> words = Console.ReadLine().Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

        List<string> lower = new List<string>();
        List<string> mixed = new List<string>();
        List<string> upper = new List<string>();

        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].All(char.IsLower))
            {
                lower.Add(words[i]);
            }
            else if (words[i].All(char.IsUpper))
            {
                upper.Add(words[i]);
            }
            else
            {
                mixed.Add(words[i]);
            }
        }
        Console.WriteLine("Lower-case: " + string.Join(", ", lower));
        Console.WriteLine($"Mixed-case: " + string.Join(", ", mixed));
        Console.WriteLine($"Upper-case: " + string.Join(", ", upper));
    }
}

