using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }

    public string ID { get; set; }

    public int Age { get; set; }
}

class OrderbyAge
{
    static void Main()
    {
        List<Person> persons = new List<Person>();
        string input = Console.ReadLine();

        while (input != "End")
        {
            var tokens = input.Split(' ');
            var name = tokens[0];
            string id = tokens[1];
            var age = int.Parse(tokens[2]);

            Person person = new Person()
            {
                Name = name,
                ID = id,
                Age = age
            };
            persons.Add(person);

            input = Console.ReadLine();
        }
        persons = persons.OrderBy(x => x.Age).ToList();

        foreach (var item in persons)
        {
            Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
        }
    }
}

