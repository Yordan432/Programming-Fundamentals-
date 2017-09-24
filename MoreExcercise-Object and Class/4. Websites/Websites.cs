using System;
using System.Collections.Generic;
using System.Linq;


class Website
{
    public string Host { get; set; }
    public string Domain { get; set; }
    public string Queries { get; set; }
}

class WebsitesDemo
{
    static void Main()
    {
        List<Website> listWebsite = new List<Website>();
        string input = Console.ReadLine();

        while (input != "end")
        {
            var tokens = input.Split('|');
            var host = tokens[0];
            var domein = tokens[1];
            string queries = null;
            if (tokens.Length != 2)
            {
                queries = tokens[2];
            }
            Website website = new Website()
            {
                Host = host,
                Domain = domein,
                Queries = queries,
            };
            listWebsite.Add(website);
            input = Console.ReadLine();
        }
        Website websiteList = new Website();
        foreach (var item in listWebsite)
        {
            var host = item.Host.Trim();
            var domein = item.Domain.Trim();

            if (item.Queries == null)
            {
                Console.WriteLine("https://www.{0}.{1}", host, domein);
            }
            else
            {
                var queries = item.Queries.Trim().Split(',');
                var queriesPrint = SolveProblemWithQueries(queries);
                Console.WriteLine($"https://www.{host}.{domein}/query?={string.Join("&", queriesPrint).Trim()}");
                //Console.WriteLine("https://www.{0}.{1}/query?=[{2}]&[{3}]", host, domein, queries[0].Trim(), queries[1].Trim());
                //https://www.{host}.{domain}/query?=[{query1]&[{query2}]&[query3]. . .

            }

        }
    }

    private static string[] SolveProblemWithQueries(string[] queries)
    {
        queries = queries.Select(q => "[" + q + "]").ToArray();
        return queries;
    }
}

