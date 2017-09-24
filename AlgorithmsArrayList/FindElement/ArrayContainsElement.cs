using System;
using System.Collections.Generic;
using System.Linq;
class ArrayContainsElement
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());

        bool isFindNumber = false;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == n)
            {
                Console.WriteLine("yes");
                return;
            }
            isFindNumber = true;
        }
        if (isFindNumber)
        {
            Console.WriteLine("no");
        }
    }
}

