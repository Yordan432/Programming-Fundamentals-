using System;

class ChooseDrink2
{
    static void Main(string[] args)
    {
        const double water = 0.70;
        const double coffe = 1.00;
        const double beer = 1.70;
        const double tea = 1.20;
        string profession = Console.ReadLine();
        int quentity = int.Parse(Console.ReadLine());

        if (profession == "Athlete")
        {
            var price = quentity * water;
            Console.WriteLine("The Athlete has to pay {0:f2}." , price);
        }
        else if (profession == "SoftUni Student")
        {
            var price = quentity * beer;
            Console.WriteLine("The SoftUni Student has to pay {0:f2}." , price);
        }
        else if (profession == "Businessman" || profession == "Businesswoman")
        {
            // check wheter have man or woman
            var price = quentity * coffe;
            Console.WriteLine($"The {profession} has to pay {price:f2}.");
        }
        else 
        {
            var price = quentity * tea;
            Console.WriteLine($"The {profession} has to pay {price:f2}.");
        }
    }
}

