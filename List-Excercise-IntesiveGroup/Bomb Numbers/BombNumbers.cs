using System;
using System.Collections.Generic;
using System.Linq;
class BombNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Count; i++)
        {
            var findNumber = bomb[0];
            var power = bomb[1];
            for (int idx = 0; idx < numbers.Count; idx++)
            {
                if (numbers[idx] == findNumber)
                {
                    var index = idx;
                   // numbers.RemoveRange(index, power);
                    for (int j = 0; j <power; j++)
                    {
                        numbers.RemoveAt(index + power);
                    }
                    for (int k = power; k > 0; k--)
                    {
                        numbers.RemoveAt(index - power);
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" " , numbers));
    }
}

