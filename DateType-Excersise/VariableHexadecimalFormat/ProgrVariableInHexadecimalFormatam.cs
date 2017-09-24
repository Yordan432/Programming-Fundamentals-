using System;

class ProgrVariableInHexadecimalFormatam
{
    static void Main()
    {
        string variableHexadecimalFormat = Console.ReadLine();
        int convertToInt = Convert.ToInt32(variableHexadecimalFormat, 16);
        Console.WriteLine(convertToInt);
    }
}

