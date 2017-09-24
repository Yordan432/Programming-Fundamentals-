using System;
using System.Collections.Generic;
using System.Linq;
class MostFrequentNumber
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Dictionary<int, int> counters = new Dictionary<int, int>();

        for (int i = 0; i <numbers.Length; i++)
        {
            if (!counters.ContainsKey(numbers[i]))
            {
                counters.Add(numbers[i], 0);
            }
            counters[numbers[i]]++;
        }

        int max = counters.Values.Max();
        var left = counters.Where(x => x.Value == max).Select(x => x.Key).Take(1).ToArray().Sum();
        Console.WriteLine(left);
    }
}

