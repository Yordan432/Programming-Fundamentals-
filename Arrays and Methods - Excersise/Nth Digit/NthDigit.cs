using System;
using System.Linq;

public class NthDigit 
{
   public static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int index = int.Parse(Console.ReadLine());

        int currentIndex = 1;
        while (numbers > 0)
        {
            if (currentIndex == index)
            {
                numbers %= 10;
                break;
            }
            else
            {
                numbers /= 10;
            }
            currentIndex++;
        }
        Console.WriteLine(numbers);
    }
}

