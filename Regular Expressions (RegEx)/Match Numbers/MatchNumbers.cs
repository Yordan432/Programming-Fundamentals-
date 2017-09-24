using System;
using System.Text.RegularExpressions;

class MatchNumbers
{
    static void Main()
    {
        string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

        string nums = Console.ReadLine();

        MatchCollection mathces = Regex.Matches(nums, regex);

        foreach (Match item in mathces)
        {
            Console.Write(item.Value + " ");
        }
        Console.WriteLine();
    }
}

