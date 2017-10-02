using System;

class X
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int row = 0; row < number; row++)
        {
            for (int col = 0; col < number; col++)
            {
                if (col == row)
                {
                    Console.Write("x");
                }
                else if(col == number - row - 1)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}

