using System;

class BeverageLabels
{
    static void Main()
    {
        var product = Console.ReadLine();
        var volume = int.Parse(Console.ReadLine());
        var energy = double.Parse(Console.ReadLine());
        var sugar = int.Parse(Console.ReadLine());

        var total = (energy / 100.0) * volume;
        var totalSugar = (sugar * volume) / 100.0;
        Console.WriteLine($"{volume}ml {product}:");
        Console.WriteLine($"{total}kcal, {totalSugar}g sugars");
        
        



    }
}

