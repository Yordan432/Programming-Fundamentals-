using System;
using System.Collections.Generic;
using System.Linq;
class RandomizeWords
{
    static void Main()
    {
        var rnd = new Random();

        var words = Console.ReadLine().Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            var rndWord = rnd.Next(words[i].Length);
            var swap = words[rndWord];
            words[rndWord] = words[i];
            words[i] = swap;
        }
        Console.WriteLine(string.Join("\n" , words));

    }
}

