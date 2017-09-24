using System;
using System.Linq;

class CountGivenArray
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            var current = numbers[i];
            if (current == n)
            {
                count++;
            }

        }
        Console.WriteLine(count);
    }
}

