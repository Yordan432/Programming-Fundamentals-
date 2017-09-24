using System;
class OddNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        while(true)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("The number is: {0}", Math.Abs(number));
                return;
            }
        }
    }
}

