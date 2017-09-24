using System;
class LastKNumbersSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] sequenceArray = new int[n];

        int prevSum = Factoriel(k);
    }
    static int Factoriel(int k)
    {
        if (k < 1)
        {
            return 1;
        }
        return k * Factoriel(k - 1);
    }
}

