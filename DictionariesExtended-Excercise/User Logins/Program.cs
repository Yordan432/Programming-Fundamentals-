using System;
using System.Collections.Generic;
using System.Linq;
class UserLogins
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();

        Dictionary<string, string> user = new Dictionary<string, string>();
        int failedRegister = 0;
        while (true)
        {
            if (input[0] == "login")
            {
                while (true)
                {
                    input = Console.ReadLine().Split(' ').ToList();
                    if (input[0] == "end")
                    {
                        Console.WriteLine("unsuccessful login attempts: {0}" , failedRegister);
                        return;
                    }
                    if (user.ContainsKey(input[0]) && user.ContainsValue(input[2]))
                    {
                        Console.WriteLine($"{input[0]}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]}: login failed");
                        failedRegister++;
                    }
                }         
            }
            else
            {
                user[input[0]] = input[2];
            }        
            input = Console.ReadLine().Split(' ').ToList();
        }
   }
}

