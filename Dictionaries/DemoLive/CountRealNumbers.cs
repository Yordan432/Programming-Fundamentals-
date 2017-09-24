using System;
using System.Collections.Generic;
using System.Linq;
class CountRealNumbers
{
    static void Main()
    {
        SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (!dictionary.ContainsKey(numbers[i]))
            {
                dictionary.Add(numbers[i], 0);
            }
            dictionary[numbers[i]]++;
        }
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        };
    }
}

