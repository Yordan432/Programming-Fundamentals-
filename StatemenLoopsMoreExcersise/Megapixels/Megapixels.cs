using System;

class Megapixels
{
    static void Main()
    {
        decimal width = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());
       
        decimal totalSum = width * height;
        decimal result = totalSum / 1000000;
        Console.WriteLine(Math.Round(result , 2) + "MP");
    }
}

