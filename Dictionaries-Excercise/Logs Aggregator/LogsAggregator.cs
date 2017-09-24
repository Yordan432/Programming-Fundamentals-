using System;
using System.Collections.Generic;
using System.Linq;
class LogsAggregator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var logUser = new Dictionary<string, Dictionary<int, string>>();
        var logUsers = new Dictionary<string, Dictionary<string, List<string>>>();

        List<double> ips = new List<double>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            string ip = input[0];
            var name = input[1];
            var number = int.Parse(input[2]);
            if (!logUser.ContainsKey(name))
            {
                logUser[name] = new Dictionary<int, string>();
                logUsers[name] = new Dictionary<string, List<string>>();
            }
            if (!logUser[name].ContainsValue(ip))
            {
                if (logUser[name].Count >= 1)
                {
                    var value = logUser[name].Keys.ToArray();
                    number = value[0] += number;
                    logUser[name].Add(number, ip);
                }
                else
                {
                    logUser[name].Add(number, ip);
                }
            }
        }
        foreach (var user in logUser)
        {
            Console.WriteLine($"{user.Key}:");
            foreach (var value in user.Value)
            {
                var valueNumber = value.Key;
                var ip = value.Value;
                Console.WriteLine($" {valueNumber} [ {ip} ]");
               
            }
        }
    }
}

