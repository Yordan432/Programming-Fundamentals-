using System;
using System.Collections.Generic;
using System.Linq;

class Dog
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int NumberOfLegs { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
    }
}
class Cat
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int IntelligenceQuotient { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
    }
}
class Snake
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int CrueltyCoefficient { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
    }
}
class Animals
{
    static void Main()
    {
        Dictionary<string, Dog> dogs = new Dictionary<string, Dog>();
        Dictionary<string, Cat> cats = new Dictionary<string, Cat>();
        Dictionary<string, Snake> snakes = new Dictionary<string, Snake>();

        string input = Console.ReadLine();

        while (input != "I'm your Huckleberry")
        {
            var tokens = input.Split(' ');
            if (tokens.Length > 2)
            {
                string type = tokens[0];
                var name = tokens[1];
                var age = int.Parse(tokens[2]);
                var parameter = int.Parse(tokens[3]);

                switch (type)
                {
                    case "Dog":
                        Dog newDog = new Dog();
                        newDog.Name = name;
                        newDog.Age = age;
                        newDog.NumberOfLegs = parameter;

                        dogs.Add(newDog.Name, newDog);

                        break;

                    case "Cat":
                        Cat newCat = new Cat();
                        newCat.Name = name;
                        newCat.Age = age;
                        newCat.IntelligenceQuotient = parameter;

                        cats.Add(newCat.Name, newCat);

                        break;

                    case "Snake":
                        Snake newSnake = new Snake();
                        newSnake.Name = name;
                        newSnake.Age = age;
                        newSnake.CrueltyCoefficient = parameter;

                        snakes.Add(newSnake.Name, newSnake);
                        break;
                }
            }
            else
            {
                var animal = tokens[1];
                if (dogs.ContainsKey(animal))
                {
                    dogs[animal].ProduceSound();
                }
                else if (cats.ContainsKey(animal))
                {
                    cats[animal].ProduceSound();
                }
                else
                {
                    snakes[animal].ProduceSound();
                }
            }
            input = Console.ReadLine();
        }
        foreach (var dog in dogs.Values)
        {
            Console.WriteLine("Dog: {0} , Age: {1} , Number Of Legs: {2}" , dog.Name , dog.Age , dog.NumberOfLegs);
        }
        foreach (var cat in cats.Values)
        {
            Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}" , cat.Name , cat.Age , cat.IntelligenceQuotient);
        }
        foreach (var snake in snakes.Values)
        {
            Console.WriteLine("{Snake: {0}, Age: {1}, Cruelty: {2}" , snake.Name , snake.Age , snake.CrueltyCoefficient);
        }
    }

}

