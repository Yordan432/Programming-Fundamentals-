using System;
class FloatOrInteger
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double result = Math.Floor(number);
        Console.WriteLine("{0:f0}" ,result);
    }
}

