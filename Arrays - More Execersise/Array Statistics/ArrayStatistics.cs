using System;
using System.Linq;

class ArrayStatistics
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        int min = int.MaxValue;
        int max = int.MinValue;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = (int)numbers[i];
            }
            if (numbers[i] > max)
            {
                max = (int)numbers[i];
            }
            
        }
        var sum = Sum(numbers);
        double average = sum / numbers.Length;
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Average = {0}" ,average);
    }

    private static double Sum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}

