using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class OddLines
{
    static void Main()
    {
        var readLines = File.ReadAllLines("text.txt");

        var oddLine = readLines.Where((line, index) => index % 2 != 0).ToArray();

        File.WriteAllLines("outputOddLine.txt", oddLine);
        Console.WriteLine(string.Join("\n" , oddLine));
        
    }
}

