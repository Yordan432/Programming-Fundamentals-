using System;
using System.Collections.Generic;
using System.Linq;
class FindtheLetter
{
    static void Main()
    {
        var firstItems = Console.ReadLine();
        var findItem = Console.ReadLine().Split(' ');

        var tokens = firstItems.Split(' ');
        var indexNum = int.Parse(findItem[1]);
        var findElement = findItem[0].ToString();

        if (indexNum > tokens.Length)
        {
            Console.WriteLine("Find the letter yourself!");
            return;
        }

        var chIndex = firstItems.IndexOf(findElement[0], 0);
        int charIndex = firstItems.IndexOf(findElement[0], 0);

        while (indexNum != 1)
        {
            chIndex = firstItems.IndexOf(findElement[0], chIndex + 1);
            indexNum--;
        }
    }
}

