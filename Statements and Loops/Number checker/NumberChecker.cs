using System;

class NumberChecker
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine("It is a number.");
        }
        catch (InvalidCastException e)
        {
           // throw new YourCustomException("Put your error message here.", e);
        }
    }
}

