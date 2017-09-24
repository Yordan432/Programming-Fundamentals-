using System;

class MultiplicationTable2
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var endNumber = int.Parse(Console.ReadLine());
        var sum = 0;

        for (int i = firstNumber; i <= 10; i++)
        {
            sum = firstNumber * i;
            Console.Write(firstNumber + " X ");
            Console.Write(i + " = ");
            Console.WriteLine("" + sum);
        }
    }
}

