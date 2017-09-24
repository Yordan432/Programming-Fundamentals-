using System;
using System.Collections.Generic;
using System.Linq;
class MinerTask
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, int> resource = new Dictionary<string, int>();
        List<string> listWord = new List<string>();
        List<int> listValue = new List<int>();
        int odd = 1;

        while (input != "stop")
        {
            if (odd % 2 != 0)
            {
                listWord.Add(input);
            }
            else
            {
                var parse = int.Parse(input);
                listValue.Add(parse);
            }
            if (listWord.Count > 0 && listValue.Count > 0)
            {
                var key = listWord[0];
                var value = listValue[0];
                if (resource.ContainsKey(key))
                {
                    var resourceToArray = resource.Values.ToArray();
                    var valueToArray = listValue.ToArray();
                    var sum = resourceToArray[0] + valueToArray[0];
                    resource[key] = sum;

                }
                else
                {
                    resource[key] = value;
                }
            
                listValue.Clear();
                listWord.Clear();
            }
            odd++;
            input = Console.ReadLine();
        }

        foreach (var item in resource)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

