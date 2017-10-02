using System;

class ExactProductRealNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal sum = decimal.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            decimal currentNumber = decimal.Parse(Console.ReadLine());
            sum *= currentNumber;
        }
        Console.WriteLine(sum);
    }
}

