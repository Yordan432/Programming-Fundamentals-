using System;

class DrawAFilledSquare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        FirstPart(n);
        MiddlePart(n);
        MiddlePart(n);
        FirstPart(n);
    }
    static void FirstPart(int n)
    {
        Console.WriteLine(new string('-' , n * 2));
    }

    static void MiddlePart(int n)
    {
        // Console.WriteLine(new string('-', n * 2));
        Console.Write("-");
        for (int i = 1; i < n; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }
}

