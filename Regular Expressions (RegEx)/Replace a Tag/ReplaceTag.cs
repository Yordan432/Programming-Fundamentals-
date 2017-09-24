using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        List<string> result = new List<string>();
        string input = Console.ReadLine();
        while (input != "end")
        {
            string url = "<a\\s*?href=\"(.+?)\">(\\w+)<\\/\\w>";
            string replacement = "[URL href=\"$1\"]$2[/URL]";
            var mathces = Regex.Replace(input, url, replacement);
            result.Add(mathces);
            input = Console.ReadLine();
        }
        Console.WriteLine(string.Join("\n" , result));
    }
}

