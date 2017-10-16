using System;
using System.Collections.Generic;
using System.Linq;
class ShortWordsSorted
{
    static void Main()
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine().ToLower().Split(new char[] 
        { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '/', '!', '?', ' ' },
            StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length < 5).Distinct().OrderBy(x => x).ToList()));
    }
}

