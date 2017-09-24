using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string Model { get; set; }

    public string Color { get; set; }

    public int Horsepower { get; set; }
}
class Truck
{
    public string Model { get; set; }

    public string Color { get; set; }

    public int Horsepower { get; set; }
}

class VehicleCatalogue
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        List<Truck> trucks = new List<Truck>();
        string input = Console.ReadLine().ToLower();

        while (input != "End")
        {
            var tokens = input.Split(' ');
            var type = tokens[0];

            if (type == "car")
            {
                var model = tokens[1];
                var color = tokens[2];
                var horsepower = int.Parse(tokens[3]);

                Car car = new Car
                {
                    Model = model,
                    Color = color,
                    Horsepower = horsepower
                };
                cars.Add(car);
            }
            else
            {
                var model = tokens[1];
                var color = tokens[2];
                var horsepower = int.Parse(tokens[3]);

                Truck druck = new Truck
                {
                    Model = model,
                    Color = color,
                    Horsepower = horsepower
                };
                trucks.Add(druck);
            }

            input = Console.ReadLine();
        }
        string command = Console.ReadLine().ToLower();

        Car carIstance = new Car();
        while (command != "Close the Catalogue")
        {
            foreach (var car in cars)
            {
                var isTypeModel = car.Model;

                if (command == isTypeModel)
                {
                    Console.WriteLine($"Type: {car}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Color: {car.Color}");
                    Console.WriteLine($"Horsepower: {car.Horsepower}");
                }
            }


            foreach (var truck in trucks)
            {
                var isTypeModel = truck.Model;
                if (command == isTypeModel)
                {
                    Console.WriteLine($"Type: {truck}");
                    Console.WriteLine($"Model: {truck.Model}");
                    Console.WriteLine($"Color: {truck.Color}");
                    Console.WriteLine($"Horsepower: {truck.Horsepower}");
                }
            }
            command = Console.ReadLine();
        }
        double averageCar = 0;
        double averageTrucks = 0.0;
        foreach (var item in cars)
        {
            var horspowerValue = item.Horsepower;
            averageCar += horspowerValue;
        }
        foreach (var item in trucks)
        {
            var horsepower = item.Horsepower;
            averageTrucks += horsepower;
        }
        Console.WriteLine($"Cars have average horsepower of: {averageCar / cars.Count:f2}");
        Console.WriteLine($"Trucks have average horsepower of: {averageTrucks / trucks.Count:f2}");

    }
}

