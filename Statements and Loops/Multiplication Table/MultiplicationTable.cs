using System;

class MultiplicationTable
{
    static void Main()
    {
        var multiplication = int.Parse(Console.ReadLine());
        var sum = 0;

        for (int i = 1; i <=10; i++)
        {
           sum = multiplication * i;
            Console.Write(multiplication + " X ");
            Console.Write(i + " = ");
            Console.WriteLine("" + sum);
        }
        Console.WriteLine();
    }
}

