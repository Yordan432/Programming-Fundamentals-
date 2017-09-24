using System;
using System.Collections.Generic;
using System.Linq;
class FixEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, string> emails = new Dictionary<string, string>();
        List<string> names = new List<string>();
        List<string> email = new List<string>(); 

        int isRowEmails = 0;
        while (input != "stop")
        {
            if (isRowEmails % 2 != 0)
            {
                email.Add(input);
            }
            else
            {
                names.Add(input);
            }
            isRowEmails++;
            if (names.Count > 0 && email.Count > 0)
            {
                emails.Add(names[0], email[0]);

                names.Clear();
                email.Clear();
            }
            input = Console.ReadLine();
        }
        foreach (var item in emails)
        {
            var toCharArrayEmails = item.Value.ToCharArray();
            if (toCharArrayEmails.Contains('.') && toCharArrayEmails.Contains('u') && toCharArrayEmails.Contains('s'))
            {
                emails.Remove(item.Key);
                break;
            }
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

