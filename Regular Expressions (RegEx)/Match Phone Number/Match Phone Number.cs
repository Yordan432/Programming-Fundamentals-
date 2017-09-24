using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class MatchPhoneNumber
{
    static void Main()
    {
        //                    \+359(-| )2(-| )\d{3}(-| )\d{4}\b - diff ?
        Regex regex = new Regex(@"\+359(-|\s)2\1\d{3}\1\d{4}\b");
        
        string input = Console.ReadLine();
        MatchCollection mathes = regex.Matches(input);
        List<string> result = new List<string>();
        foreach (Match item in mathes)
        {
            result.Add(item.Value.Trim());
        }
        Console.WriteLine(string.Join(", " , result));
    }
}

