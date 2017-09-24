using System;
using System.Collections.Generic;
using System.Linq;
class MixedPhones
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        SortedDictionary<string, long> phoneNumber = new SortedDictionary<string, long>();
        while (input[0] != "Over")
        {
            long parseNumber;
            var isParseToNumber = long.TryParse(input[0],out parseNumber);
            if (isParseToNumber)
            {
                phoneNumber.Add(input[2], parseNumber);
            }
            else
            {
                var parseToNumber = long.Parse(input[2]);
                phoneNumber.Add(input[0], parseToNumber);
            }
            input = Console.ReadLine().Split(' ');
        }

        foreach (var item in phoneNumber)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

