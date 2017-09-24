using System;
using System.Linq;

class SortArrayInsertionSortArray
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            var nextCurrentIndex = i + 1;
            while (nextCurrentIndex > 0)
            {
                if (numbers[nextCurrentIndex] < numbers[nextCurrentIndex - 1])
                {
                    var temp = numbers[nextCurrentIndex];
                    numbers[nextCurrentIndex] = numbers[nextCurrentIndex - 1];
                    numbers[nextCurrentIndex - 1] = temp;
                }
                nextCurrentIndex--;
            }
            
        }
        Console.WriteLine(string.Join(" " , numbers));
    }
}

