using System;
class SmallestElementinArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var maxNumber = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }
        }
        Console.WriteLine(maxNumber);
    }
}

