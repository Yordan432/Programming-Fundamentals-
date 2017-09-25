using System;
using System.Linq;

class VaporStore
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        string[] games = new string[] { "OutFall 4", "CS: OG", "Zplinter Zell", "Honored 2", "RoverWatch", "RoverWatch Origins Edition" };
        double[] pricePerGames = { 39.99, 15.99, 19.99, 59.99, 29.99, 39.99 };

        string input = Console.ReadLine();
        double totalSpend = 0;
        while (input != "Game Time")
        {
            if (!games.Contains(input))
            {
                Console.WriteLine("Not Found");
            }
            if (input == "OutFall 4")
            {
                if (balance < pricePerGames[0])
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }
                balance -= pricePerGames[0];
                totalSpend += pricePerGames[0];
                Console.WriteLine("Bought " + games[0]);
            }
            else if (input == "CS: OG")
            {
                if (balance < pricePerGames[1] && balance > 0)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }
                balance -= pricePerGames[1];
                totalSpend += pricePerGames[1];
                Console.WriteLine("Bought " + games[1]);
            }
            else if (input == "Zplinter Zell")
            {
                if (balance < pricePerGames[2] && balance > 0)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }
                balance -= pricePerGames[2];
                totalSpend += pricePerGames[2];
                Console.WriteLine("Bought " + games[2]);
            }
            else if (input == "Honored 2")
            {
                if (balance < pricePerGames[3] && balance > 0)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }
                balance -= pricePerGames[3];
                totalSpend += pricePerGames[3];
                Console.WriteLine("Bought " + games[3]);
            }
            else if (input == "RoverWatch")
            {
                if (balance < pricePerGames[4] && balance > 0)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }
                balance -= pricePerGames[4];
                totalSpend += pricePerGames[4];
                Console.WriteLine("Bought " + games[4]);
            }
            else if (input == "RoverWatch Origins Edition")
            {
                if (balance < pricePerGames[5] && balance > 0)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }
                balance -= pricePerGames[5];
                totalSpend += pricePerGames[5];
                Console.WriteLine("Bought " + games[5]);
            }
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }

            input = Console.ReadLine();
        }
        Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", totalSpend, balance);
    }
}