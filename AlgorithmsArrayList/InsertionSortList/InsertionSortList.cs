using System;
using System.Linq;
using System.Collections.Generic;
class InsertionSortList
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> sortNumbers = new List<int>();
        
        for (int i = 0; i < numbers.Count; i++)
        {
            bool isInsert = false;
            for (int j = 0;  j < sortNumbers.Count;  j++)
            {
                if (numbers[i] < sortNumbers[j])
                {
                    sortNumbers.Insert(j, numbers[i]);
                    isInsert = true;
                    break;
                }
            }
            if (!isInsert)
            {
                sortNumbers.Add(numbers[i]);
            }
            
        }
        Console.WriteLine(string.Join(" " , sortNumbers));
    }
}

