using System;
using System.Collections.Generic;
using System.Linq;
class CntSubstrOccurrences
{
    static void Main()
    {
        string words = Console.ReadLine().ToLower();
        string findWord = Console.ReadLine().ToLower();

        int lastIndex = -1;
        int counter = 0;
        while (true)
        {
            var index = words.IndexOf(findWord, lastIndex + 1);
            if (index != -1)
            {
                counter++;
                lastIndex = index;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(counter);
    }
}

