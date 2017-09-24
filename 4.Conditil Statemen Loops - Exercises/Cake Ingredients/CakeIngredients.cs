using System;
using System.Linq;

class CakeIngredients
{
    static void Main()
    {
        var input = Console.ReadLine();
       
        var count = 0;
        while (input != "Bake!")
        {
            count++;
            Console.WriteLine($"Adding ingredient {input}.");
            input = Console.ReadLine();
        }
        Console.WriteLine($"Preparing cake with {count} ingredients.");
    }
}

