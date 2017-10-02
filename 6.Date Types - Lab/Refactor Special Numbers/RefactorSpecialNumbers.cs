using System;

class RefactorSpecialNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int sumDigit = 0;
            int digits = 0;
            digits = i;
            while (digits > 0)
            {
                sumDigit += digits % 10;
                digits /= 10;
            }
            bool SpecialNumbers = sumDigit == 5 || sumDigit == 7 || sumDigit == 11;
            Console.WriteLine($"{i} -> {SpecialNumbers}");
           
        }

    }
}

