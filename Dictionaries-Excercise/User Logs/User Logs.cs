using System;
using System.Collections.Generic;
using System.Linq;
class UserLogs
{
    static void Main(string[] args)
    {
        var ip = new SortedDictionary<string, Dictionary<string, int>>();
        string[] userLogs = Console.ReadLine().Split(new char[] { '=', '\'', ' ' });

        while (userLogs[0] != "end")
        {
            var currentUser = userLogs[7];
            var currentIP = userLogs[1];
            var message = userLogs[4];

            if (!ip.ContainsKey(currentUser))
            {
                ip[currentUser] = new Dictionary<string, int>();
            }
            if (!ip[currentUser].ContainsKey(currentIP))
            {
                ip[currentUser].Add(currentIP, 0);
            }    
            ip[currentUser][currentIP]++;
            userLogs = Console.ReadLine().Split(new char[] { '=', '\'', ' ' });
        }

        int counRow = 1;
        foreach (var user in ip.Keys)
        {
            Console.WriteLine($"{user}: ");
            foreach (var ipAndCounter in ip[user].Keys)
            {
                var currenIp = string.Join(", ", ip[user][ipAndCounter]);
                if (counRow != ip.Count)
                {
                    Console.Write($"{ipAndCounter} => {currenIp}, ");
                }
                else
                {
                    Console.Write($"{ipAndCounter} => {currenIp}.");
                    Console.WriteLine();
                    continue;
                }
                counRow++;
            }
        }
    }
}

