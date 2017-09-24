using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class RegisteredUsers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        SortedDictionary<string, DateTime> dateUser = new SortedDictionary<string, DateTime>();

        while (input[0] != "end")
        {
            var name = input[0];
            var date = input[1];

            string format = "dd/MM/yyyy";
            DateTime dateTime = DateTime.ParseExact(date,
                format, CultureInfo.InvariantCulture);

            dateUser.Add(name, dateTime);

            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }    
        var sorted = dateUser.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(v => v.Value);
        foreach (var user in sorted)
        {
            Console.WriteLine($"{user.Key}");
        }
    }
}

