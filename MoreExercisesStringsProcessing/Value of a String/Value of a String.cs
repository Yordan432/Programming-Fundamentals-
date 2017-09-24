using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string @case = Console.ReadLine();

        int sumUpperCase = 0;
        int sumLowerCase = 0;

        int sumUpper = FindSumUpperCase(input, @case, sumUpperCase);
        int sumLower = FindSumLowerCase(input, @case, sumLowerCase);
        if (@case == "LOWERCASE")
        {
            Console.WriteLine("The total sum is: {0}", sumLower);
            return;
        }       
        Console.WriteLine("The total sum is: {0}" , sumUpper);
    }

    private static int FindSumLowerCase(string input, string @case, int sumLowerCase)
    {
        char[] lower = input.ToCharArray();
        for (int i = 0; i < lower.Length; i++)
        {
            if (!char.IsUpper(lower[i]))
            {
                sumLowerCase += lower[i];
            }
        }
        return sumLowerCase;
    }

    private static int FindSumUpperCase(string input, string @case, int sumUpperCase)
    {
        char[] upper = input.ToCharArray();
        for (int i = 0; i < upper.Length; i++)
        {
            if (char.IsUpper(upper[i]))
            {
                sumUpperCase += upper[i];
            }
        }
        return sumUpperCase;
    }
}

