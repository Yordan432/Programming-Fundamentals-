using System;
using System.Collections.Generic;
using System.Linq;
class MaxEqualElements
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> sequenceElements = new List<int>();
        sequenceElements.Add(0);
        int len = 1;
        int index = 0;
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (index == numbers.Count - 2)
            {
                if (len >=sequenceElements.Count)
                {
                    sequenceElements.RemoveRange(0, sequenceElements.Count);
                    while (numbers[index] == numbers[index + 1])
                    {
                        len++;
                        i++;
                        index++;
                        if (index == numbers.Count - 1)
                        {
                            for (int add = 0; add < len; add++)
                            {
                                sequenceElements.Add(numbers[i]);                
                            }
                            Console.WriteLine(string.Join(" ", sequenceElements));
                            return;
                         
                        }
                    }         
                }
            }
            while (numbers[index] == numbers[index + 1])
            {
                len++;
                i++;
                index++;
                if (index == numbers.Count - 1)
                {
                    Console.WriteLine(string.Join(" ", sequenceElements));
                    return;
                }
            }
            GiveMaxSequence(numbers, sequenceElements, len, i);
            len = 1;
            index++;
        }
    }

    private static void GiveMaxSequence(List<int> numbers, List<int> sequenceElements, int len, int i)
    {
        if (len > sequenceElements.Count)
        {
            sequenceElements.RemoveRange(0, sequenceElements.Count);
            for (int add = 0; add < len; add++)
            {
                sequenceElements.Add(numbers[i]);
            }
        }
    }
}

