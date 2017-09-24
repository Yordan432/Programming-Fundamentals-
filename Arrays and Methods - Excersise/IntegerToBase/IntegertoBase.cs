using System;
class IntegertoBase
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var toBase = int.Parse(Console.ReadLine());

        var result = IntegerBase(n, toBase);
        Console.WriteLine(result);
    }
    static string IntegerBase(int number , int toBase)
    {
        string result = "";

        while (number > 0)
        {
            int remainder = number % toBase;
            result = remainder + result;
            number /= toBase;
        }

        return result;
    }
}

