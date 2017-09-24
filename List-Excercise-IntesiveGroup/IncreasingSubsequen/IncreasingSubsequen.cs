using System;
using System.Collections.Generic;
using System.Linq;
class IncreasingSubsequen
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> lenght = new List<int>();
        List<int> prev = new List<int>();
        List<int> longestIncreasingSubsequence = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            var firstElement = numbers[i];
            var secondElement = numbers[i + 1];

            if (firstElement < secondElement)
            {    
                if (!longestIncreasingSubsequence.Contains(firstElement))
                {
                    longestIncreasingSubsequence.Add(firstElement);
                }
            }
            else
            {
                int index = 0;
                var element = longestIncreasingSubsequence[index];
                if (element < secondElement)
                {
                    longestIncreasingSubsequence.Add(secondElement);
                }
                index++;
               
            }
        }
    }
}

