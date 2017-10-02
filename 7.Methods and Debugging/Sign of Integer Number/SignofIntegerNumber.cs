using System;

class SignofIntegerNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BasicsWhetherNumberIsPositiveOrNegative(n);
    }
    static void BasicsWhetherNumberIsPositiveOrNegative(int n)
    {
        CheckPositiveNumber(n);
        CheckNegativeNumber(n);
        CheckZeroNumber(n);

    }
    static void CheckPositiveNumber(int n)
    {
        if (n > 0)
        {
            Console.WriteLine($"The number {n} is positive.");
        }
    }
    static void CheckNegativeNumber(int n)
    {
        if (n < 0)
        {
            Console.WriteLine($"The number {n} is negative.");

        }
    }
    static void CheckZeroNumber(int n)
    {
        if (n == 0)
        {
            Console.WriteLine($"The number {n} is zero.");

        }
    }
}

