using System;
using System.Collections.Generic;
using System.Linq;
class DictRefAdvanced
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new string[] { " -> " , ", "} , StringSplitOptions.RemoveEmptyEntries);

        var dict = new Dictionary<string, List<int>>();

        while (input[0] != "end")
        {
            List<int> numbers = new List<int>();
            bool isNumber = false;
            var key = input[0];
            var values = input;
            for (int i = 0; i < values.Length; i++)
            {
                int parseNumber;
                var isParseToNumber = int.TryParse(values[i], out parseNumber);
                if (isParseToNumber)
                {
                    numbers.Add(parseNumber);
                    isNumber = true;
                }
                else
                {
                    isNumber = false;
                    if (dict.ContainsKey(values[i]))
                    {
                        var existKey = dict[values[i]];
                        dict[key] = existKey;
                    }
                }
            }
            if (isNumber)
            {
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<int>();
                }
                dict[key].AddRange(numbers);
            }
            numbers.Clear();
            input = Console.ReadLine().Split(new string[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var key in dict)
        {
            var keys = key.Key;
            var values = dict[keys];
            Console.Write($"{keys} === ");
            foreach (var item in dict[keys])
            {
                Console.WriteLine($"{string.Join(", ", dict[keys])}");
                break;
            }    
        }
    }
}

