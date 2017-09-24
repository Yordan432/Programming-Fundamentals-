using System;
using System.Collections.Generic;
using System.Linq;
class FlattenDictionary
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Dictionary<string, Dictionary<string, string>> dict = new Dictionary<string, Dictionary<string, string>>();

        while (input[0] != "end")
        {
            if (input[0] == "flatten")
            {
                var keyCommand = input[1];
                dict[keyCommand] = dict[keyCommand].ToDictionary(x => x.Key + x.Value, x => "flatten");
                input = Console.ReadLine().Split();
                continue;
            }
            var key = input[0];
            var innerKey = input[1];
            var innerValue = input[2];

            if (!dict.ContainsKey(key))
            {
                dict[key] = new Dictionary<string, string>();
            }
            if (!dict[key].ContainsKey(innerKey))
            {
                dict[key].Add(innerKey, innerValue);
            }
            if (!dict[key][innerKey].Contains(innerValue))
            {
                dict[key][innerKey] = innerValue;
            }
            input = Console.ReadLine().Split();
        }

        Dictionary<string, Dictionary<string, string>> descendingOrder = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, Dictionary<string, string>> ascendingOrder = new Dictionary<string, Dictionary<string, string>>();

        foreach (var key in dict.OrderByDescending(x => x.Key))
        {
            if (!dict[key.Key].ContainsValue("flatten"))
            {
                var keys = key.Key;
                Console.WriteLine($"{keys} :");
                descendingOrder.Add(keys, new Dictionary<string, string>());
                foreach (var value in key.Value.OrderBy(x => x.Key.Length))
                {
                    var keyValue = value.Key;
                    var values = value.Value;
                    descendingOrder[keys].Add(keyValue, values);
                }
            }
            if (dict[key.Key].ContainsValue("flatten"))
            {
                foreach (var item in dict)
                {
                    var keyItem = item.Key;
                    ascendingOrder.Add(keyItem, new Dictionary<string, string>());
                    foreach (var value in item.Value)
                    {        
                        var nestedKey = value.Key;
                        if (value.Value == "flatten")
                        {
                            ascendingOrder[keyItem].Add(value.Key, value.Value);
                        }
                    }

                }
            }
        }
    }
}

