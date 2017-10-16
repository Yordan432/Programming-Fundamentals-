using System;
using System.Collections.Generic;
using System.Linq;
class FoldandSum
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int k = numbers.Count / 4;
        var firstKElements = numbers.Take(k).Reverse().ToList();
        var lastKElements = numbers.Skip(numbers.Count - k).Reverse();
        firstKElements = firstKElements.Concat(lastKElements).ToList();


        var middlePart = numbers.Skip(k).Take(k * 2).ToList();

        var sum = new List<int>();
        for (int i = 0; i < firstKElements.Count; i++)
        {
            sum.Add(firstKElements[i] += middlePart[i]);
        }
        Console.WriteLine(string.Join(" " , sum));
    }
}

