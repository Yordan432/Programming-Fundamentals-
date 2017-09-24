using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class SumBigNumbers
{
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();

        BigInteger sum = SumNumbers(firstNumber, secondNumber);
        Console.WriteLine(sum);
    }
    private static BigInteger SumNumbers(string firstNumber, string secondNumber)
    {
        BigInteger num1 = BigInteger.Parse(firstNumber);
        BigInteger num2 = BigInteger.Parse(secondNumber);
        BigInteger sum = num1 + num2;

        return sum;

    }
}

