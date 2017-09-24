using System;
using System.Collections.Generic;
using System.Linq;
class DeserializeString
{
    static void Main()
    {
        string input = Console.ReadLine();

        SortedDictionary<int, string> date = new SortedDictionary<int, string>();
        while (input != "end")
        {
            var tokens = input.Split(':');
            var alhabet = tokens[0];
            var values = tokens[1].Split('/').Select(int.Parse).ToArray();

            foreach (var nums in values)
            {
                date.Add(nums, alhabet.ToString());
            }
            input = Console.ReadLine();
        }
        Console.WriteLine(string.Join("" , date.Values.ToArray()));
    }
}

