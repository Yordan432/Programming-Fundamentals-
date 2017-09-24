using System;
class NeighbourWars
{
    static void Main()
    {
        int peshoDamage = int.Parse(Console.ReadLine());
        int goshoDamage = int.Parse(Console.ReadLine());

        int healthPlayer1 = 100;
        int healthPlayer2 = 100;
        int round = 1;
        int attacksRestore = 1;
        int countRounds = 1;
        while (true)
        {
            if (round % 2 != 0)
            {
                healthPlayer2 -= peshoDamage;
                if (healthPlayer1 <= 0 || healthPlayer2 <= 0)
                {
                    Console.WriteLine("Pesho won in {0}th round." , countRounds);
                    break;
                }
                Console.Write("Pesho used Roundhouse kick and reduced" + " ");
                Console.WriteLine("Gosho to {0} health." , healthPlayer2);
            }
            else
            {
                healthPlayer1 -= goshoDamage;
                if (healthPlayer1 <= 0 || healthPlayer2 <= 0)
                {
                    Console.WriteLine("Gosho won in {0}th round." , countRounds);
                    break;
                }
                Console.Write("Gosho used Thunderous fist and reduced" + " ");
                Console.WriteLine("Pesho to {0} health." , healthPlayer1);
            }
            if (attacksRestore == 3)
            {
                attacksRestore = 1;
                healthPlayer2 += 10;
                healthPlayer1 += 10;
                round++;
                countRounds++;
                continue;
            }
            round++;
            countRounds++;
            attacksRestore++;
        }
    }
}

