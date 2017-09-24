using System;

class FromTerabytestoBits
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        double result = number * 1024 * 1024 * 1024 * 1024 * 8;
        Console.WriteLine(result);
    }
}

