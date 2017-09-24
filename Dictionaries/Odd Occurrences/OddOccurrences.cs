using System;
using System.Collections.Generic;
using System.Linq;
class OddOccurrences
{
    static void Main()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
        for (int i = 0; i < input.Count; i++)
        {
            if (!dictionary.ContainsKey(input[i]))
            {
                dictionary.Add(input[i], 0);
            }
            dictionary[input[i]]++;
        }
        List<string> output = new List<string>();
        foreach (var item in dictionary)
        {
            if (item.Value % 2 != 0)
            {
                output.Add(item.Key);        
            }
        }
        Console.WriteLine(string.Join(", " , output));
    }
}

