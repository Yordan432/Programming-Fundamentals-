using System;
using System.Collections.Generic;
using System.Linq;

class CurrentExcercise
{
    public string Topic { get; set; }
    public string CourseName { get; set; }
    public string JudgeContestLink { get; set; }
    public List<string> Problems { get; set; }
}

class Exercises
{
    static void Main()
    {
        List<CurrentExcercise> excercise = new List<CurrentExcercise>();
        string input = Console.ReadLine();

        while (input != "go go go")
        {
            var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var topic = tokens[0];
            var couseName = tokens[1];
            var linkToJudge = tokens[2];
            var problems = tokens[3].Split(',').ToList();

            CurrentExcercise excerciseCurrent = new CurrentExcercise
            {
                Topic = topic,
                CourseName = couseName,
                JudgeContestLink = linkToJudge,
                Problems = problems,
            };
            excercise.Add(excerciseCurrent);

            input = Console.ReadLine();
        }

        foreach (var item in excercise)
        {
            Console.WriteLine("Exercises: {0}" , item.Topic);
            Console.WriteLine(@"Problems for exercises and homework for the ""{0}"" course @ SoftUni." , item.CourseName);
            Console.WriteLine("Check your solutions here: {0}" , item.JudgeContestLink);

            int count = 1;
            foreach (var excercis in item.Problems)
            {
                Console.WriteLine("{0}. {1}" , count , excercis.Trim());
                count++;
            }
        }
      // PrintResult(excercise);
    }

    private static void PrintResult(List<CurrentExcercise> excercise)
    {
        int count = 1;
        foreach (var item in excercise)
        {
            var topic = item.Topic;
            var courseName = item.CourseName;
            var linkJudge = item.JudgeContestLink;
            var problems = item.Problems;

            Console.WriteLine($"Exercises: {topic}");
            Console.WriteLine(@"Problems for exercises and homework for the ""{0}"" course @ SoftUni.", courseName);
            Console.WriteLine("Check your solutions here: \n{0}" , linkJudge);
     
            foreach (var problem in problems)
            {
                Console.WriteLine($"{count}. {problem.Trim()}");
                count++;
            }

        }
        
     
    }
}

