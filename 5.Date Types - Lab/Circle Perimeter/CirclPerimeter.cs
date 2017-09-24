using System;
class CirclPerimeter 
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        double result = 2 * Math.PI * num;
        Console.WriteLine("{0:f12}" , result);
    }
}

