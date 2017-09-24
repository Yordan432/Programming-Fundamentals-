using System;
using System.Collections.Generic;
using System.Linq;
class Rabbit_Hole
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        int energy = int.Parse(Console.ReadLine());
        bool isBomb = false;
        int position = 0;
        while (energy > 0)
        {
            string[] tokens = input[position].Split('|');
            switch (tokens[0])
            {
                case "Right":
                    position = (position + int.Parse(tokens[1])) % input.Count;
                    energy -= int.Parse(tokens[1]);
                    break;
                case "Left":
                    //int temp = int.Parse(tokens[1]) - position;
                    //position = (temp + int.Parse(tokens[1])) % input.Count;
                    //energy -= int.Parse(tokens[1]);
                    //Console.WriteLine(position);
                    energy -= int.Parse(tokens[1]);
                    position = Math.Abs(position - int.Parse(tokens[1])) % input.Count;

                    break;
                case "Bomb":
                    int energyTokens = int.Parse(tokens[1]);
                    energy -= energyTokens;
                    input.RemoveAt(position);
                    position = 0;
                    isBomb = true;
                    break;
                case "RabbitHole":
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;  
            }
            if (energy <= 0)
            {
                if (isBomb)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                    break;
                }
                else
                {
                    Console.WriteLine("You are tired. You can't continue the mission");
                    break;
                }
            }
            if (input[input.Count -1] != "RabbitHole ")
            {
                input.RemoveAt(input.Count - 1);
            }
            input.Add("Bomb|" + energy);
        }
    }
}

