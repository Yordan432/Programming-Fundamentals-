using System;
using System.Collections.Generic;
using System.Linq;
class CypherRoulette
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var normal = "";
        var currentWord = "";

        var prev = "";

        for (int i = 0; i < n; i++)
        {
            currentWord = Console.ReadLine();

            if (currentWord != "spin")
            {
                normal += currentWord;
            }
            if (currentWord == "spin")
            {
                currentWord = Console.ReadLine().Trim();
                var changeToLis = currentWord.ToList();
                normal += currentWord;
            }
            if (prev == currentWord)
            {
                normal = " ";
                currentWord = " ";
            }
            prev = currentWord;
        }
        Console.WriteLine(normal.Trim());
    }

}

