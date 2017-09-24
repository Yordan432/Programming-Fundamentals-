using System;
class BlankReceipt
{
    static void Main()
    {
        Header();
        Body();
        Foother();
    }
    static void Header()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }
    static void Body()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }
    static void Foother()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("© SoftUni");
    }
}

