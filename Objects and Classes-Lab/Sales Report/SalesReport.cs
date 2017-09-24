using System;
using System.Collections.Generic;
using System.Linq;

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }
}

class TotalSale
{

}
class SalesReport
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Sale> townSales = new List<Sale>();

        for (int i = 0; i < n; i++)
        {
            Sale sale = ReadSale(Console.ReadLine());
            townSales.Add(sale);
        }
        Dictionary<string, double> townTotalPrice = new Dictionary<string, double>();
        for (int i = 0; i < townSales.Count; i++)
        {
            var allSales = townSales.Select(s => s.Town).ToList();
            var currentTown = allSales[i];

            var prices = townSales.Select(p => p.Price).ToList();
            var currentPrice = prices[i];

            var amounts = townSales.Select(q => q.Quantity).ToList();
            var currentAmount = amounts[i];

            var sum = prices[i] * amounts[i];
            if (!townTotalPrice.ContainsKey(allSales[i]))
            {
                townTotalPrice.Add(allSales[i], sum);
            }
            else
            {
                foreach (var price in townTotalPrice.Values)
                {                  
                    var value = sum * price;
                    townTotalPrice[allSales[i]] = value;
                }               
            }           
        }
        foreach (var item in townTotalPrice)
        {
            var town = item.Key;
            var price = item.Value;
            Console.WriteLine($"{town} -> {price}");
        }

    }

    private static Sale ReadSale(string input)
    {
        string[] splitInput = input.Split(' ');
        string town = splitInput[0];
        string product = splitInput[1];
        double price = double.Parse(splitInput[2]);
        double amount = double.Parse(splitInput[3]);

        return new Sale
        {
            Town = town,
            Product = product,
            Price = price,
            Quantity = amount
        };
    }
}

