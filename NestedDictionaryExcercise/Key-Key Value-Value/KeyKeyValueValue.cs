using System;
using System.Collections.Generic;
using System.Linq;
class KeyKeyValueValue
{
    static void Main()
    {
        string keyFound = Console.ReadLine();
        string value = Console.ReadLine();

        Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new string[] { " => "} , StringSplitOptions.RemoveEmptyEntries);
            var keys = input[0];
            var values = input[1].Split(';').ToList();
            List<string> equalWords = new List<string>();
            if (keys.Contains(keyFound))
            {
                equalWords.Clear();
                for (int v = 0; v < values.Count; v++)
                {
                    if (values[v].Contains(value))
                    {
                        equalWords.Add(values[v]);
                    }
                }
                pairs.Add(keys, equalWords);
            }
        }
        foreach (var kvp in pairs.Keys)
        {
            Console.WriteLine($"{kvp}:");
            foreach (var values in pairs[kvp])
            {
                Console.WriteLine($"-{string.Join("\n" ,values)}");
            }
        }
    }
}

