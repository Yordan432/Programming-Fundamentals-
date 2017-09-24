using System;
using System.Collections.Generic;
using System.Linq;
class TextFilter
{
    static void Main()
    {
        string[] bannWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string words = Console.ReadLine();

        foreach (var banWord in bannWords)
        {
            words = words.Replace(banWord, new string('*', banWord.Length));
        }
        Console.WriteLine(words);
    }
}

