using System;
using System.Collections.Generic;
using System.Linq;
class SortArrayBubbleAlgorithm
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        bool swap;
        do
        {
            swap = false;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var firstElement = numbers[i];
                var secondElement = numbers[i + 1];
                if (firstElement > secondElement)
                {
                    var temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    swap = true;
                }
            }
        } while (swap);

        Console.WriteLine(string.Join(" " , numbers));
    }
}

