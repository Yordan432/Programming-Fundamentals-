using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public string Username { get; set; }

    public List<Messages> ReceivedMessages { get; set; }

    public User(string username, List<Messages> messagess)
    {
        this.Username = username;
        this.ReceivedMessages = messagess;
    }
}
class Messages
{
    public string Content { get; set; }

    public User Sender { get; set; }

    public Messages(string content, User sender)
    {
        this.Content = content;
        this.Sender = sender;
    }
}

class MessagesDemo
{
    static void Main()
    {
        var users = new Dictionary<string, User>();

        string input = Console.ReadLine();
        string sender;
        string recipient;
        while (input != "exit")
        {
            var tokens = input.Split(' ');
            if (tokens[0] == "register")
            {
                var username = tokens[1];
                User user = new User(username, new List<Messages>());
                users.Add(username, user);
            }
            else
            {
                sender = tokens[0];
                recipient = tokens[2];
                var content = tokens[3];

                if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                {
                    User senderUser = users[sender];
                    users[recipient].ReceivedMessages.Add(new Messages(content, senderUser));
                }
            }

            input = Console.ReadLine();
        }
        string[] chatTokens = Console.ReadLine().Split();
        sender = chatTokens[0];
        recipient = chatTokens[1];

        var senderMessage = users[recipient].ReceivedMessages.Where(m => m.Sender.Username == sender).ToArray();

        var recipientMessage = users[sender].ReceivedMessages.Where(m => m.Sender.Username == recipient).ToArray();

        var index = 0;

        if (senderMessage.Length == 0 && recipientMessage.Length == 0)
        {
            Console.WriteLine("No messages");
        }

        while (index < senderMessage.Length && index < recipientMessage.Length)
        {
            Console.WriteLine("{0}: {1}" , sender , senderMessage[index].Content);
            Console.WriteLine("{0} :{1}" , recipientMessage[index].Content , recipient);
            index++;
        }
        while (index < senderMessage.Length)
        {
            Console.WriteLine("{0}: {1}", sender, senderMessage[index].Content);
            index++;
        }
        while (index < recipientMessage.Length)
        {
            Console.WriteLine("{0} :{1}", recipientMessage[index].Content, recipient);
            index++;
        }
    }
}

