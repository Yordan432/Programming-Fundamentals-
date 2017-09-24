using System;
class AddTwoNumbers
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var lastNumber = int.Parse(Console.ReadLine());
        var sum = firstNumber + lastNumber;
        Console.WriteLine($"{firstNumber} + {lastNumber} = {sum}");

    }
}

