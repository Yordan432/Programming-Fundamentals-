using System;

class Transport
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double capacity = (4 + 8 + 12);
        double courser = Math.Ceiling(n / capacity);
        Console.WriteLine(courser);
    }
}

