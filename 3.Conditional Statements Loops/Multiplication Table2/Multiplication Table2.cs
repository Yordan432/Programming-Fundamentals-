using System;
class MultiplicationTable2
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());

        for (int i = multiplier; i <=10; i++)
        {
            Console.WriteLine($"{number} X {i} = {number * i}");
        }
        if(multiplier > 10)
        {
            Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            return;
        }
    }
}

