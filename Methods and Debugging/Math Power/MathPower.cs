using System;

class MathPower
{
    static void Main()
    {
        var result = CalculatePow(2 , 8);
        Console.WriteLine(result);
    }
    static int CalculatePow(int firstNumber, int lastNumber)
    {
        int prev = firstNumber;
        for (int i = 1; i <lastNumber; i++)
        {
            prev *= firstNumber;
            lastNumber -= 1;
        }
        return prev;
    }
}

