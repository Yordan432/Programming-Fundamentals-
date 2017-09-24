using System;
using System.Linq;

class CountCapitalLetters
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToArray();
        var count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == words[i].ToUpper())
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

