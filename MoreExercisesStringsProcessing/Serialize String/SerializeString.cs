using System;
using System.Collections.Generic;
using System.Linq;
class SerializeString
{
    static void Main()
    {
        string input = Console.ReadLine();
        var result = SerializeS(input);

        int lastRow = 0;
        foreach (var item in result)
        {
            Console.Write($"{item.Key}:");
            foreach (var indexs in item.Value)
            {
                lastRow++;
                if (item.Value.Count == lastRow)
                {
                    Console.Write($"{indexs}");
                    break;
                }
                Console.Write($"{indexs}/");
            }
            lastRow = 0;
            Console.WriteLine();
        }
    }
    private static Dictionary<char, List<int>> SerializeS(string input)
    {
        Dictionary<char, List<int>> wordIndex = new Dictionary<char, List<int>>();
        char[] date = input.ToCharArray();
        for (int i = 0; i < date.Length; i++)
        {
            if (!wordIndex.ContainsKey(date[i]))
            {
                wordIndex[date[i]] = new List<int>();
            }
            wordIndex[date[i]].Add(i);
        }
        return wordIndex;
    }
}

