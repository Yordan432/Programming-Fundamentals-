using System;
using System.Linq;

class ProRotateArrayofString
{
    static void Main()
    {
        var word = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        var result = new char[word.Length];
        result[0] = word[word.Length - 1];

        for (int i = 0; i < word.Length - 1; i++)
        {
            result[i + 1] = word[i];
        }
        Console.WriteLine(string.Join(" " , result));
    }
}

