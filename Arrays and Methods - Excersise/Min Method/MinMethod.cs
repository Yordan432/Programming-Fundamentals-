using System;
class MinMethod
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var lastNumber = int.Parse(Console.ReadLine());
        var threeNumber = int.Parse(Console.ReadLine());

        var minNumber = GetMin(firstNumber , lastNumber);

        if (minNumber < threeNumber)
        {
            Console.WriteLine(minNumber);
        }
        else
        {
            Console.WriteLine(threeNumber);
        }

    }
    static int GetMin(int a , int b)
    {
        if (a < b)
        {
            return a;
        }
        return b;
    }
}

