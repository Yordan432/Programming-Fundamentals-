using System;
class SumOfOddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int countOdd = n;
        int sumOddNumbers = 0;
        for (int i = 1; i <=countOdd; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
                sumOddNumbers += i;
                countOdd++;
            }
            if(countOdd == n)
            {
                break;
            }
        }
        Console.WriteLine("Sum: " + sumOddNumbers);
    }
}
