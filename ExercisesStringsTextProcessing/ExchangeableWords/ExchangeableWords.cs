using System;
using System.Collections.Generic;
using System.Linq;
class ExchangeableWords
{
    static void Main()
    {
        var input = Console.ReadLine().Split();

        ExchangeableWordsMethod(input);
    }

    private static void ExchangeableWordsMethod(string[] input)
    {
        bool[] isExchangeWords = new bool[input.Length];
        var firstItems = input[0];
        var secondItems = input[1];



    }
}

