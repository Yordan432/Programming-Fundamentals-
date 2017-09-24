﻿using System;
using System.Collections.Generic;
using System.Linq;
class Largest3Numbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

       var result = numbers.OrderByDescending(x => x).Take(3);
        Console.WriteLine(string.Join(" " , result));
    }
}

