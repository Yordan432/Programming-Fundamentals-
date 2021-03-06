﻿using System;
using System.Collections.Generic;
using System.Linq;
class Phonebook
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        while (input[0] != "END")
        {
            if (input[0] == "A")
            {
                phonebook[input[1]] = input[2];
            }
            if (input[0] == "S")
            {
                var contains = input[1];
                if (!phonebook.ContainsKey(contains))
                {
                    Console.WriteLine("Contact {0} does not exist." , input[1]);
                }
                else
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{contains} -> {phonebook[contains]}");
                        break;
                    }
                }
            }
            input = Console.ReadLine().Split();
        }
    }
}

