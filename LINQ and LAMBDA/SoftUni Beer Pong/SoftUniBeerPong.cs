using System;
using System.Collections.Generic;
using System.Linq;
class SoftUniBeerPong
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('|');

        Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

        while (input[0] != "stop the game")
        {
            var team = input[0];
            var player = input[1];
            var points = int.Parse(input[2]);

            if (!dict.ContainsKey(player))
            {
                dict[player] = new Dictionary<string, int>();
            }
            dict[player].Add(team, points);

            input = Console.ReadLine().Split('|');
        }
        Dictionary<string, Dictionary<string, int>> teamGroupPlayers = new Dictionary<string, Dictionary<string, int>>();
        var maxCount = 1;
        foreach (var team in dict)
        {
            if (dict[team.Key].Count >= 3)
            {
                teamGroupPlayers[team.Key] = new Dictionary<string, int>();
                foreach (var players in team.Value)
                {
                    if (maxCount <= 3)
                    {
                        var player = players.Key;
                        var point = players.Value;
                        teamGroupPlayers[team.Key].Add(player, point);
                        maxCount++;
                    }
                }
            }
            else
            {
                continue;
            }
            maxCount = 1;
        }
        int count = 1;
        foreach (var item in teamGroupPlayers.OrderByDescending(x => x.Key))
        {
            var players = teamGroupPlayers[item.Key];
            Console.WriteLine($"{count}. {item.Key}; Players:");
            foreach (var player in item.Value.OrderByDescending(x => x.Value))
            {
                var playersName = player.Key;
                var point = player.Value;
                Console.WriteLine($"###{playersName}: {point}");
            }
            count++;
        }
    }
}

