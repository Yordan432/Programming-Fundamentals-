using System;
using System.Collections.Generic;
using System.Linq;
class StringDecryption
{
    static void Main()
    {
        int[] skipElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] takeAfterSkipElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        TakeLettersASCIICapital(skipElements , takeAfterSkipElements);
       
    }
    private static void TakeLettersASCIICapital(int[] skipElements, int[] takeAfterSkipElements)
    {
        for (int i = 65; i <=90; i++)
        {
            var skip = takeAfterSkipElements.Skip(skipElements[i]);
        }
    }
}

