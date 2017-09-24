using System;

class DebitCardNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourNumber = int.Parse(Console.ReadLine());

        Console.Write(firstNumber.ToString("D4") + " ");
        Console.Write(secondNumber.ToString("D4") + " ");
        Console.Write(thirdNumber.ToString("D4") + " ");
        Console.Write(fourNumber.ToString("D4") + " ");
        Console.WriteLine();

    }
}

