using System;
using System.Collections.Generic;
using System.Linq;
class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        var result = input.Select(t => string.Format("\\u{0:x4}", Convert.ToUInt16(t))).ToList();

        Console.WriteLine(string.Join("" , result));

    }
}

