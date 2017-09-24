using System;
class TestNumbers
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var maximum = int.Parse(Console.ReadLine());
        var combination = 0;
        var sum = 0;
        for (int i = n; i >=1; i--)
        {
            for (int j = 1; j <=m; j++)
            {
                sum +=3 * i * j;
                combination++;
                if (sum >= maximum)
                {
                    Console.WriteLine($"{combination} combinations");
                    Console.WriteLine($"Sum: {sum} >= {maximum}");
                    return;
                }
            }
        }
        Console.WriteLine($"{combination} combinations");
        Console.WriteLine($"Sum: {sum}");

    }
}

