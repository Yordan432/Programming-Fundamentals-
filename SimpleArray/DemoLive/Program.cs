using System;
class Program
{
    static void Main(string[] args)
    {
        // long
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());

        long[] arr = new long[n];
        arr[0] = 1;
        for (int i = 1; i < n; i++)
        {
            arr[i] = SumNums(arr, i - k , i - 1);
        }
        Console.WriteLine(string.Join(" " , arr));
    }

    private static long SumNums(long[] arr , long startIndex, long endIndex)
    {
        long sum = 0;
        for (long i = startIndex; i <= endIndex; i++)
        {
            if (i >= 0)
            {
                sum += arr[i];
            }
        }
        return sum;
    }
}

