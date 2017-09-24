using System;

class OddNumber
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        while (n % 2 == 0)
        {
            n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine($"The number is: {n}");
                break;
            }
            else
            {
                Console.WriteLine("Please write an odd number.");
                n = int.Parse(Console.ReadLine());
                break;
            }
        }
    }
}

