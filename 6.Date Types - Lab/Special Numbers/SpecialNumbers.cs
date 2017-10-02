using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <=n; i++)
        {
            int sumDigit = 0;
            int digits = i;
            while (digits > 0)
            {
                sumDigit += digits % 10;
                digits /= 10;
            }
            bool isSpecialNumber = sumDigit == 5 || sumDigit == 7 || sumDigit == 11;
            Console.WriteLine("{0} -> {1}" , i , isSpecialNumber);
           
        }
        Console.WriteLine();
    }
}

