using System;
using System.Collections.Generic;
using System.Linq;
class DistinctList
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var result = numbers.Distinct();
        Console.WriteLine(string.Join(" " , result));
    }
}

