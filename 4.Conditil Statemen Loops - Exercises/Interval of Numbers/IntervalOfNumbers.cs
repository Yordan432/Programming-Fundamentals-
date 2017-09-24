using System;

class IntervalOfNumbers
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var lastNumber = int.Parse(Console.ReadLine());
        
        if (firstNumber < lastNumber)
        {
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        if (lastNumber < firstNumber)
        {
            for (int i = lastNumber; i <= firstNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

