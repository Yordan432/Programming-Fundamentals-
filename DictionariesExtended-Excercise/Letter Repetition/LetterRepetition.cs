using System;
using System.Collections.Generic;
using System.Linq;
class LetterRepetition
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] inputItems = input.ToCharArray();

        Dictionary<char, int> countItem = new Dictionary<char, int>();

        for (int i = 0; i < inputItems.Length; i++)
        {
            if (!countItem.ContainsKey(inputItems[i]))
            {
                countItem.Add(inputItems[i], 0);
            }
            countItem[inputItems[i]]++;
        }
        foreach (var item in countItem)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

