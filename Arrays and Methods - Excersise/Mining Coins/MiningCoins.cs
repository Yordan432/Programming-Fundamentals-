using System;
class MiningCoins
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        string message = "";
        float value = 0;

        for (int i = 1; i <=number; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());
            int digits1 = currentNumber / 100;
            int digits2 = (number % 100) / 10;
            int digits3 = currentNumber % 10;

            value += (digits1 + digits2 + digits3) / (float)number;
            int asccii = 0;

            if (i % 2 != 0)
            {
                asccii = ((digits1 * 10) + digits3) - digits2;
            }
            else
            {
                asccii = ((digits1 * 10) + digits3) + digits2;
            }
        }
    }
}

