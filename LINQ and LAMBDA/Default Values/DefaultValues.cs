using System;
using System.Collections.Generic;
using System.Linq;
class DefaultValues
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        var defaulValues = new Dictionary<string, string>();

        while (input[0] != "end")
        {
            var key = input[0];
            var value = input[1];
            defaulValues.Add(key, value);
            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }
        string defaultInput = Console.ReadLine();
        var valuesDefault1 = new Dictionary<string, string>();
        var valuesDefault2 = new Dictionary<string, string>();

        var diffNull = PrintFirstDiffOfNull(defaulValues, valuesDefault1);
        var allNull = PrintAllEqualNull(defaulValues, defaultInput, valuesDefault2);

        var allValues = diffNull.Concat(allNull);

        foreach (var item in allValues)
        {
            var key = item.Key;
            var value = item.Value;
            Console.WriteLine($"{key} <-> {value}");
        }
    }
    private static Dictionary<string, string> PrintAllEqualNull(Dictionary<string, string> defaulValues, string word, Dictionary<string, string> valuesDefault)
    {
        foreach (var key in defaulValues)
        {
            if (key.Value == "null")
            {
                valuesDefault.Add(key.Key, word);
            }
        }
        var orderby = valuesDefault.OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, v => v.Value);
        return orderby;


    }
    private static Dictionary<string, string> PrintFirstDiffOfNull(Dictionary<string, string> defaulValues, Dictionary<string, string> valuesDefault2)
    {
        foreach (var kvp in defaulValues.Keys)
        {
            if (defaulValues[kvp] != "null")
            {
                valuesDefault2.Add(kvp, defaulValues[kvp]);
            }
        }
        var orderby = valuesDefault2.OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, v => v.Value);
        return orderby;
    }
}

