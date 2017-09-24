using System;
using System.Collections.Generic;
using System.Linq;
class KeyReplacer
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            input.ToCharArray();
            if (!dict.ContainsKey(input[i]))
            {
                dict[input[i]] = 0;
            }
            dict[input[i]]++;
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

