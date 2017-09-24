using System;
using System.Collections.Generic;
using System.Linq;
class ArrayDate
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        string command = Console.ReadLine();

        double sum = TotalSumNumbers(numbers);
        double average = FindAverageFromTotalSumNumbers(numbers, sum);
        List<double> largeAverageNumbers = RemoveAllSmallerFromAverage(numbers, average);

        if (command == "Min")
        {
            Console.WriteLine(string.Join(" " ,largeAverageNumbers.Min()));
        }
        else if(command == "Max")
        {
            Console.WriteLine(string.Join(" " ,largeAverageNumbers.Max()));
        }
        else 
        {
            largeAverageNumbers.Sort();
            Console.WriteLine(string.Join(" " ,largeAverageNumbers));
        }

    }

    private static List<double> RemoveAllSmallerFromAverage(List<double> numbers, double average)
    {
        List<double> largeAverageNumbers = new List<double>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > average)
            {
                largeAverageNumbers.Add(numbers[i]);
            }
        }
        return largeAverageNumbers;
    }

    private static double FindAverageFromTotalSumNumbers(List<double> numbers, double sum)
    {
        double avg = sum / numbers.Count;
        return avg;
    }
    private static int TotalSumNumbers(List<double> numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        return (int)sum;
    }
}

