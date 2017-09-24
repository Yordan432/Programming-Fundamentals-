using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        //string regex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)";

        string regex = @"[^-|.]?(\w+\.)?(\w+\.|\w*)@(\w*\.\w*)*$";
        MatchCollection matches = Regex.Matches(Console.ReadLine(), regex);

        foreach (Match item in matches)
        {
            if (item.ToString() != "@")
            {
                Console.WriteLine(item.Value);
            }
            
        }
    }
}

