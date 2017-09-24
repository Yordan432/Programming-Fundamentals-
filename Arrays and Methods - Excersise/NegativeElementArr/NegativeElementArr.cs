using System;

class NegativeElementArr
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countNegativeNumber = 0;

        for (int i = 0; i <n ; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber < 0)
            {
                countNegativeNumber++;
            }
        }
        Console.WriteLine(countNegativeNumber);
    }
}

