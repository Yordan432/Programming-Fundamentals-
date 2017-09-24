using System;
class GameOfNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int countCombination = 0;
        for (int i = firstNumber; i <=secondNumber; i++)
        {
            for (int j = firstNumber; j <=secondNumber; j++)
            {
                if (i + j == magicNumber)
                {
                    Console.WriteLine("Number found! {0} + {1} = {2}" , j , i , i + j);
                    return;
                }
                countCombination++;
            }
        }
        Console.WriteLine("{0} combinations - neither equals {1}" , countCombination , magicNumber);
    }
}

