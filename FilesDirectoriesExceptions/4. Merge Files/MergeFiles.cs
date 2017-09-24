using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class MergeFiles
{
    static void Main()
    {
        var file1 = File.ReadAllLines("input1.txt");
        var file2 = File.ReadAllLines("input2.txt");
        File.WriteAllLines("output.txt", file1.Concat(file2));

        var concatFile = File.ReadAllLines("output.txt");

        var orderFiles = concatFile.OrderBy((e => e)).ToArray();

        File.WriteAllLines("outputSortedNums.txt", orderFiles);
    }
}

