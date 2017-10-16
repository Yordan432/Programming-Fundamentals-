using System;
using System.Collections.Generic;
using System.Linq;
class OddOccurrences
{
    static void Main()
    {
        var input = Console.ReadLine().ToLower().Split(' ').ToArray();

        Dictionary<string, int> dict = new Dictionary<string, int>();

        int counter = 0;
        foreach (var item in input)
        {
            if (!dict.ContainsKey(item))
            {
                dict[item] = counter;
            }
            dict[item]++;
        }
        int row = 0;
        List<string> output = new List<string>();
        foreach (var item in dict.Distinct())
        {
            if (item.Value % 2 != 0)
            {
                output.Add(item.Key);
            }
        }
       
       Console.WriteLine(string.Join(", " , output));
    }
}

