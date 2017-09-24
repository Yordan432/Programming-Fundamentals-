using System;
using System.Collections.Generic;
using System.Linq;
class IncreasingCrisis
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();

        for (int i = 0; i < n; i++)
        {
            InsertNumber(list);
            NumberRemove(list);
        }
        Console.WriteLine(string.Join(" " , list));
    }

    private static void NumberRemove(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                for (int removed = i + 1; removed < list.Count; removed++)
                {
                    list.RemoveAt(removed);
                    removed--;
                }
            }
        }
    }

    private static void InsertNumber(List<int> list)
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        bool isEmptyList = list.Count == 0 || list[list.Count - 1] <= input[0];
        if (isEmptyList)
        {
            for (int i = 0; i < input.Count; i++)
            {
                list.Add(input[i]);
            }
        }
        else
        {
            int position = Position(list, input);
            var positionToEnd = position + input.Count;
            var count = 0;

            for (int i = position; i < positionToEnd; i++)
            {
                list.Insert(i, input[count]);
                count++;
                if (list[i] > list[i + 1])
                {
                    break;
                }
            }
        }

    }

    private static int Position(List<int> list, List<int> input)
    {
        var position = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > input[0])
            {
                position = i;
                break;
            }
        }
        return position;
    }
}

