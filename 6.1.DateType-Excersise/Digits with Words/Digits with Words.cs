﻿using System;

namespace DigitsWithWords
{
    class DigitsWithWords
    {
        static void Main()
        {
            string word = Console.ReadLine();
            switch (word)
            {
                case "zero":
                    Console.WriteLine(0);
                    break;
                case "one":
                    Console.WriteLine(1);
                    break;
                case "two":
                    Console.WriteLine(2);
                    break;
                case "three":
                    Console.WriteLine(3);
                    break;
                case "four":
                    Console.WriteLine(4);
                    break;
                case "five":
                    Console.WriteLine(5);
                    break;
                case "fix":
                    Console.WriteLine(6);
                    break;
                case "seven":
                    Console.WriteLine(7);
                    break;
                case "eight":
                    Console.WriteLine(8);
                    break;
                case "nine":
                    Console.WriteLine(9);
                    break;
                case "ten":
                    Console.WriteLine(10);
                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
