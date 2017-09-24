using System;
using System.Collections.Generic;
using System.Linq;
class SocialMediaPosts
{
    static void Main()
    {
        string input = Console.ReadLine();
        var dict = new Dictionary<string, Dictionary<string, List<string>>>();
        int countLike = 1;
        while (input != "drop the media")
        {
            var split = input.Split(' ').ToArray();
            string status = split[0];
            var postName = split[1];
            if (!dict.ContainsKey(postName))
            {
                dict[postName] = new Dictionary<string, List<string>>();
            }
            if (status == "like")
            {
                if (!dict[postName].ContainsKey("Like"))
                {
                    dict[postName]["Like"] = new List<string>();
                }
                dict[postName]["Like"].Add(status);
            }
            else if(status == "dislike")
            {
                if (!dict[postName].ContainsKey("Dislike"))
                {
                    dict[postName]["Dislike"] = new List<string>();
                }
                dict[postName]["Dislike"].Add(status);
            }
            else if(status == "comment")
            {
                var message = split[2];
                int lenght = status.Length + postName.Length + message.Length + 3;
                var comment = input.Substring(lenght);
                if (!dict.ContainsKey(message))
                {
                    dict[postName][message] = new List<string>();
                }
                dict[postName][message].Add(comment);
            }
            input = Console.ReadLine();
        }
        foreach (var item in dict)
        {
            int likes = 0;
            int dislike = 0;
            var writes = item.Value;
            foreach (var items in item.Value)
            {
                if (items.Key == "Like")
                {
                    likes = items.Value.Count;
                }
                else if (items.Key == "Dislike")
                {
                    dislike = items.Value.Count;
                }
            }
            Console.WriteLine($"Post: {item.Key} | Likes: {likes} | Dislike {dislike}");
            Console.WriteLine("Comments:");
            bool notComment = false;
            foreach (var comment in writes)
            {
                if (comment.Key != "Like" && comment.Key != "Dislike")
                {
                    notComment = false;
                    foreach (var comments in comment.Value)
                    {
                        Console.WriteLine($"*  {comment.Key}: {comments}");
                    }
                }
            }
            if (notComment)
            {
                Console.WriteLine("None");
            }
        }
    }
}

