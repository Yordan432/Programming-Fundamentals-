using System;
using System.Linq;

class SumArrays
{
    static void Main()
    {
        var numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < numbers1.Count; i++)
        {
            if (numbers2.Count < numbers1.Count)
            {
                numbers2.Add(numbers2[i]);
            }
            if (numbers1.Count < numbers2.Count)
            {
                numbers1.Add(numbers1[i]);
            }
        }
        for (int j = 0; j < numbers1.Count; j++)
        {
            if (numbers1.Count == numbers2.Count)
            {
                numbers1[j] += numbers2[j];
            }
        }
        Console.WriteLine(string.Join(" ", numbers1));
    }
}

