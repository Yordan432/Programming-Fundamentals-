using System;
using System.Collections.Generic;
using System.Linq;
class SentenceSplit
{
    static void Main()
    {
        var words = Console.ReadLine().Split();
        var delimiter = Console.ReadLine().Trim();

        List<string> output = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            var tokens = words[i].Split(new string[] { delimiter , ","} , StringSplitOptions.RemoveEmptyEntries);
            output.Add(tokens[0]);
        }
        Console.WriteLine("[" + string.Join(" " , output) + "]");
    }
}

