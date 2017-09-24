using System;
using System.Collections.Generic;
using System.Linq;
class DictRef
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        while (input[0] != "end")
        {
            var addNameInDictionary = input[0];

            var addValueInDictionary = input[2];
            if (!dictionary.ContainsKey(addValueInDictionary))
            {
                dictionary[addNameInDictionary] =int.Parse(addValueInDictionary);
            }
            else
            {             
                var existKey = dictionary[addValueInDictionary];
                dictionary[addNameInDictionary] = existKey;
            }
            input = Console.ReadLine().Split(' ');
        }
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key} === {item.Value}");
        }
    }
}

