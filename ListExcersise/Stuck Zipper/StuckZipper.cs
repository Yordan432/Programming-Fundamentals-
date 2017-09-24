using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> resultList = new List<int>();

        //find min length number from the two lists
        int minDigits = Math.Min(MinLength(first), MinLength(second));

        //remove items bigger than min digits
        first = RemoveBiggerThanMinSize(first, minDigits);
        second = RemoveBiggerThanMinSize(second, minDigits);

        //merge the two lists
        resultList = MergeLists(first, second);

        //print results list
        Console.WriteLine(string.Join(" ", resultList));
    }
    static int MinLength(List<int> list)
    {
        int minLength = int.MaxValue;
        for (int i = 0; i < list.Count; i++)
        {
            if (minLength > FindLength(list[i]))
            {
                minLength = FindLength(list[i]);
            }
        }
        return minLength;
    }

    static int FindLength(int number)
    {
        string numberLen = Math.Abs(number).ToString();
        return numberLen.Length;
    }

    static List<int> RemoveBiggerThanMinSize(List<int> list, int minDigits)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (FindLength(list[i]) > minDigits)
            {
                list.RemoveAt(i);
                i--;
            }
        }
        return list;
    }
    static List<int> MergeLists(List<int> list1, List<int> list2)
    {
        List<int> results = new List<int>();
        int MaxCount = Math.Max(list1.Count, list2.Count);

        for (int i = 0; i < MaxCount; i++)
        {
            if (i < list2.Count)
            {
                results.Add(list2[i]);
            }
            if (i < list1.Count)
            {
                results.Add(list1[i]);
            }
        }
        return results;
    }
}
