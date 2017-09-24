using System;
using System.Collections.Generic;
using System.Linq;
class Winecraft
{
    static void Main()
    {
        List<int> greapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());

        while (true)
        {
            for (int i = 0; i < n; i++)
            {
                var firstElement = greapes[i];
                var secondElement = greapes[i + 1];
                if (firstElement >= secondElement)
                {
                    greapes[i]++;
                }
                if (secondElement < firstElement || secondElement < greapes[i + 2])
                {
                    greapes[i + 1]--;
                }
            }
        }

    }
}

