﻿using System;
class NumberChecker
{
    static void Main()
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

