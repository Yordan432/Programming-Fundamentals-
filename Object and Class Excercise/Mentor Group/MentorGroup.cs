using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class CommentsStudent
{
    public Dictionary<string, List<string>> namesAndComments { get; set; }
}

class Student
{
    public Dictionary<string, List<string>> namesAndDate { get; set; }
}
class MentorGroup
{
    static void Main()
    {
        Student students = new Student()
        {
            namesAndDate = new Dictionary<string, List<string>>()
        };

        string readDate = Console.ReadLine();

        while (readDate != "end of dates")
        {
            var tokensDate = readDate.Split(' ');
            var name = tokensDate.First();
            var date = tokensDate[1].Split(',');

            if (!students.namesAndDate.ContainsKey(name))
            {
                students.namesAndDate.Add(name, new List<string>());
            }
            students.namesAndDate[name].AddRange(date);

            readDate = Console.ReadLine();
        }

        string readComments = Console.ReadLine();

        CommentsStudent dateComment = new CommentsStudent()
        {
            namesAndComments = new Dictionary<string, List<string>>()
        };

        while (readComments != "end of comments")
        {
            var tokensComment = readComments.Split('-');
            var name = tokensComment.First();
            var comment = tokensComment[1];
            if (!students.namesAndDate.ContainsKey(name))
            {
                readComments = Console.ReadLine();
                continue;
            }
            else
            {
                if (!dateComment.namesAndComments.ContainsKey(name))
                {
                    dateComment.namesAndComments.Add(name, new List<string>());
                }
                dateComment.namesAndComments[name].Add(comment);
            }
            readComments = Console.ReadLine();
        }
        int i = 0;
        foreach (var item in dateComment.namesAndComments.Keys)
        {
            var name = item;
            Console.WriteLine($"{name}");
            Console.WriteLine("Comments:");
            foreach (var comments in dateComment.namesAndComments.Values)
            {
                Console.WriteLine($"- {string.Join(" ", comments)}");
            }
            Console.WriteLine("Dates attended:");
            students.namesAndDate = students.namesAndDate.OrderBy(x => x.Value).ToList().ToDictionary(k => k.Key , v => v.Value);
            foreach (var date in students.namesAndDate.Values)
            {
                Console.WriteLine($"-- {string.Join("\n-- ", date)}");
                break;

            }
        }
    }
}

