using System;
using System.Collections.Generic;
using System.Linq;
class SumReversedNumbers
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ').ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            var index = numbers[i].ToCharArray();
            Array.Reverse(index);
            var strArray = new string(index);
            numbers[i] = strArray;
        }
        int[] sum = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            var element = int.Parse(numbers[i]);
            sum[i] = element;
        }
        var sums = sum.Sum();
        Console.WriteLine(string.Join(" " , sums));
    }
}

