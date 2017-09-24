using System;
using System.Linq;
using System.Collections.Generic;
class CountNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int[] nums = new int[1001];

        foreach (var num in numbers)
        {
            nums[num]++;
        }
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > 0)
            {
                Console.WriteLine($"{i} -> {nums[i]}");
            }
        }
    }
}

