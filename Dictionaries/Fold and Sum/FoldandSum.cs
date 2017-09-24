using System;
using System.Collections.Generic;
using System.Linq;
class FoldandSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var k = numbers.Length / 4;

        var firstLeftPart = numbers.First(e => e == k);

        var nums = numbers.Skip(k * 3).Reverse().ToList();
        nums = new List<int>(numbers.Take(k).Reverse().ToList().Concat(nums));
        numbers = numbers.Skip(k).Take(k * 2).ToArray();

        var result = new List<int>();
        for (int i = 0; i < k * 2; i++)
        {
            result.Add(numbers[i] + nums[i]);
        }
        Console.WriteLine(string.Join(" " , result));
    }
}

