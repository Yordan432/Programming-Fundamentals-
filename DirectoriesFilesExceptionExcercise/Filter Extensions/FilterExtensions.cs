using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class FilterExtensions
{
    static void Main()
    {
        string extension = Console.ReadLine();

        ExtensionTxt(extension);
       // ExtensionLike(extension);
        //ExtensionBmp(extension);
        //ExtensionRar(extension);

    }
    private static void ExtensionRar(string extension)
    {
        throw new NotImplementedException();
    }

    private static void ExtensionBmp(string extension)
    {
        throw new NotImplementedException();
    }

    private static void ExtensionTxt(string extension)
    {
        if (extension == "txt")
        {
            File.ReadAllText("test001.txt");
            File.WriteAllText("ouput-test001.txt", extension);
        }
    }

    private static void ExtensionLike(string extension)
    {
        throw new NotImplementedException();
    }
}

