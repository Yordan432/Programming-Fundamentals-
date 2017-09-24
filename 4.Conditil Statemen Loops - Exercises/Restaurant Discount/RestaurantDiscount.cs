using System;
class RestaurantDiscount
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        var price = 0;
        price = PriceSmallHall(size, type, price);
        price = TerraceHall(size, type, price);
        price = GreatHall(size, type, price);
    }
    private static int GreatHall(int size, string type, int price)
    {
        if (size > 100 && size < 120)
        {
            // Great Hall
            price = 7500;
            if (type == "Normal")
            {
                var priceNormal = 500;
                var profit = 0.05;
                var totalPrice = price + priceNormal;
                var disconnect = totalPrice - totalPrice * 0.05;
                var pricePerson = disconnect / size;
                Console.WriteLine("{0:f2}", pricePerson);
            }
            else if (type == "Gold")
            {
                var priceGold = 750;
                var profit = 0.10;
                var totalPrice = price + priceGold;
                var discconnect = totalPrice - totalPrice * 0.10;
                var pricePerson = discconnect / size;
                Console.WriteLine("{0:F2}", pricePerson);
            }
            else if (type == "Platinum")
            {
                var pricePlatinum = 1000;
                var profit = 0.15;
                var totalPrice = price + pricePlatinum;
                var disconncet = totalPrice - totalPrice * 0.15;
                var pricePerson = disconncet / size;
                Console.WriteLine("{0:f2}", pricePerson);
            }
        }
        if(size >=120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
        return price;
    }

    private static int TerraceHall(int size, string type, int price)
    {
        if (size > 50 && size <= 100)
        {
            //Terrace
            price = 5000;
            if (type == "Normal")
            {
                var priceNormal = 500;
                var profit = 0.05;
                var totalPrice = price + priceNormal;
                var disconnect = totalPrice - totalPrice * 0.05;
                var pricePerson = disconnect / size;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerson:f2}$");
            }
            else if (type == "Gold")
            {
                var priceGold = 750;
                var profit = 0.10;
                var totalPrice = price + priceGold;
                var disconnect = totalPrice - totalPrice * 0.10;
                var pricePerson = disconnect / size;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerson:f2}$");
            }
            else if (type == "Platinum")
            {

                var pricePlatinum = 1000;
                var profit = 0.15;
                var totalPrice = price + pricePlatinum;
                var disconnect = totalPrice - totalPrice * 0.15;
                var pricePerson = disconnect / size;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerson:f2}$");
            }
        }
        return price;
    }
    private static int PriceSmallHall(int size, string type, int price)
    {
        if (size <= 50)
        {
            // Small Hall 
            price = 2500;
            if (type == "Gold")
            {
                var priceGold = 750;
                var profit = 0.10;
                var totalPrice = price + priceGold;
                var disconnect = totalPrice - totalPrice * 0.10;
                var pricePerson = disconnect / size;
                Console.WriteLine($"We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerson:f2}$");
            }
            else if (type == "Normal")
            {
                price = 2500;
                var priceNormal = 500;
                var profit = 0.05;
                var totalPrice = price + priceNormal;
                var disconnect = totalPrice - totalPrice * 0.05;
                var pricePerson = disconnect / size;
                Console.WriteLine($"We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerson:f2}$");

            }
            else if (type == "Platinum")
            {
                price = 2500;
                var pricePlatinum = 1000;
                var profit = 0.15;
                var totalPrice = price + pricePlatinum;
                var disconnect = totalPrice - totalPrice * 0.15;
                var pricePerson = disconnect / size;
                Console.WriteLine($"We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerson:f2}$");
            }
        }
        return price;
    }
}
