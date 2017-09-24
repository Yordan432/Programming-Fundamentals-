using System;
using System.Collections.Generic;
using System.Linq;

class BankAccount
{
    public string Name { get; set; }
    public string Bank { get; set; }
    public decimal Balance { get; set; }
}

class OptimiBankSystem
{
    static void Main()
    {
        List<BankAccount> bankAcounts = new List<BankAccount>();
        string input = Console.ReadLine();

        while (input != "end")
        {
            var tokens = input.Split('|');
            var bank = tokens[0];
            var name = tokens[1];
            var balance = decimal.Parse(tokens[2]);

            BankAccount account = new BankAccount
            {
                Name = name,
                Bank = bank,
                Balance = balance
            };
            bankAcounts.Add(account);
            input = Console.ReadLine();
        }
        bankAcounts = bankAcounts.OrderByDescending(x => x.Balance).ThenBy(l => l.Bank).ToList();

        foreach (var bank in bankAcounts)
        {
            Console.WriteLine($"{bank.Name.Trim()} -> {bank.Balance} ({bank.Bank.Trim()})");
        }
    }
}

