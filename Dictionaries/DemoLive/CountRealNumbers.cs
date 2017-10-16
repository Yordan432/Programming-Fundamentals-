using System;
using System.Collections.Generic;
using System.Linq;
class CountRealNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        SortedDictionary<double, int> countNumbers = new SortedDictionary<double, int>();

        int count = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (!countNumbers.ContainsKey(numbers[i]))
            {
                countNumbers.Add(numbers[i], count);
            }
            countNumbers[numbers[i]]++;
        }

        foreach (var countNumber in countNumbers)
        {
            Console.Write(countNumber.Key + " -> ");
            Console.WriteLine(countNumber.Value);
        }
    }
}

