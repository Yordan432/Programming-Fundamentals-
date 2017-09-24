using System;
using System.Collections.Generic;
using System.Linq;
class SearchforANumber
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        List<int> takesNumbers = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            var takeNums = arr[0];

            for (int j = 0; j < takeNums; j++)
            {
                takesNumbers.Add(numbers[j]);
            }
            var deleteNums = arr[1];
            for (int k = 0; k < 1; k++)
            {
                takesNumbers.RemoveRange(0, deleteNums);
            }
            if (takesNumbers.Contains(arr[2]))
            {
                Console.WriteLine("Yes!");
                return;
            }
            else
            {
                Console.WriteLine("No!");
                return;
            }
        }
    }
}

