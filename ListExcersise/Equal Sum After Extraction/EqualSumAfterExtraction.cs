using System;
using System.Collections.Generic;
using System.Linq;

class EqualSumAfterExtraction
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < firstList.Count; i++)
        {
            var firstElement = firstList[i];
            for (int j = 0; j < secondList.Count; j++)
            {
                var secondElement = secondList[j];
                if (firstElement == secondElement)
                {
                    secondList.Remove(secondList[j]);
                }
            }
        }
        var firstSumList = firstList.Sum();
        var secondSumList = secondList.Sum();
        if (firstSumList == secondSumList)
        {
            Console.WriteLine("Yes. Sum: {0}" , firstSumList);
        }
        else
        {
            var diff = Math.Abs(firstSumList - secondSumList);
            Console.WriteLine("No. Diff: {0}" , diff);
        }
    }
}

