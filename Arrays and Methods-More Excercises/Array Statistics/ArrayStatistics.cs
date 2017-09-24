using System;
using System.Collections.Generic;
using System.Linq;
class ArrayStatistics
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

       int sum = 0;
       int min = int.MaxValue;
       int max = int.MinValue;
       double average = 0.0;

       for (int i = 0; i < numbers.Length; i++)
       {
           sum += numbers[i];
       }
       average = (double)sum / numbers.Length;

       for (int i = 0; i <numbers.Length ; i++)
       {
           if (numbers[i] < min)
           {
               min = numbers[i];
           }
       }
       for (int i = 0; i < numbers.Length; i++)
       {
           if (numbers[i] > max)
           {
               max = numbers[i];
           }
       }
      Console.WriteLine("Min = {0}" , min);
      Console.WriteLine("Max = {0}" , max);
      Console.WriteLine("Sum = {0}" , sum);
      Console.WriteLine("Average = {0}", average);

    }
}
