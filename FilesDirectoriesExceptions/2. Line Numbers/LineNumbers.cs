using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class LineNumbers
{
    static void Main()
    {
        var readFile = File.ReadAllLines("input.txt");

        var insertNumberFile = readFile.Select((line, index) => + index + ". " + line).ToArray();

        File.WriteAllLines("outputFile.txt" , insertNumberFile);
    }
}

