using System;
class PrintingTriangle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        FirstPartPrintTriangle(n);
        LastPartPrintTriangle(n);
        
    }
    static void FirstPartPrintTriangle(int n)
    {
        for (int i = 1; i <=n; i++)
        {
            for (int j = 1; j <=i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();    
        }   
    }
    static void LastPartPrintTriangle(int n)
    {
        for (int i = n; i >= 0; i--)
        {
            for (int j = 1; j <= i - 1; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

