﻿using System;
using System.Collections.Generic;
using System.Linq;
class Largest3Numbers
{
    static void Main()
    {
        Console.WriteLine(string.Join(" " ,Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).Take(3)));
    }
}

