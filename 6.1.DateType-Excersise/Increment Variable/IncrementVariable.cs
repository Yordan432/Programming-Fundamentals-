using System;

class IncrementVariable
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        byte scrolling = 0;
        int overflowed = 0;

        for (int i = 0; i < number; i++)
        {
            scrolling++;
            if (scrolling == 0)
            {
                overflowed ++;
            }
        }
        Console.WriteLine(scrolling);
        Console.WriteLine("Overflowed {0} times", overflowed );
    }
}

