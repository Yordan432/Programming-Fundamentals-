using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int temp = a;
        temp = b;
        b = a;
              
        Console.WriteLine(temp);
        Console.WriteLine(b);

    }
}

