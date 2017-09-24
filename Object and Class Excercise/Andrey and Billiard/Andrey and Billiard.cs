using System;
using System.Collections.Generic;
using System.Linq;
class Clients
{
    public List<string> Name { get; set; }
    public List<string> Product { get; set; }
    public List<int> Amount { get; set; }

}
class ProductAndPrice
{
    public List<string> products { get; set; }
    public List<double> prices { get; set; }
}

class AndreyandBilliard
{
    static void Main(string[] args)
    {
        ProductAndPrice productPrice = new ProductAndPrice();
        int n = int.Parse(Console.ReadLine());

        List<string> allProducts = new List<string>();
        List<double> allPrices = new List<double>();
        Dictionary<string, double> allProductPrices = new Dictionary<string, double>();
        for (int i = 0; i < n; i++)
        {
            string[] products = Console.ReadLine().Split('-');
            var whatProduct = products[0];
            var price = double.Parse(products[1]);
            FillAllProduct(whatProduct, productPrice, allProductPrices, price, allPrices, allProducts);
        }
        string[] command = Console.ReadLine().Split('-', ',');

        Clients client = new Clients();
        List<string> namesClients = new List<string>();
        List<string> productsClients = new List<string>();
        List<int> amountsClients = new List<int>();
        while (command[0] != "end of clients")
        {
            var name = command[0];
            var product = command[1];
            var amount = int.Parse(command[2]);

            if (!allProductPrices.ContainsKey(product))
            {
                command = Console.ReadLine().Split('-', ',');
                continue;
            }
            else
            {
                namesClients.Add(name);
                client.Name = namesClients;

                productsClients.Add(product);
                client.Product = productsClients;

                amountsClients.Add(amount);
                client.Amount = amountsClients;
            }
            command = Console.ReadLine().Split('-', ',');
        }
        var customer = new Dictionary<string, Dictionary<string, int>>();
        var result = OrderByElements(customer, client);
        Console.WriteLine();
    }

    private static Dictionary<string, Dictionary<string, int>> OrderByElements(Dictionary<string, Dictionary<string, int>> customer, Clients client)
    {
        var nameClient = client.Name;
        var productClient = client.Product;
        var amountClient = client.Amount.ToString();
        //if (!customer.ContainsKey(nameClient))
        //{
        //   // customer[nameClient] = new Dictionary<string, int>();
        //}
        //customer[nameClient].Add(productClient, ;
        customer.OrderBy(x => client.Name);

        return customer;

    }

    private static void FillAllProduct(string whatProduct, ProductAndPrice productPrice, Dictionary<string, double> allProducts, double price,
        List<double> allPrices, List<string> allProduct)
    {
        if (!allProducts.ContainsKey(whatProduct))
        {
            allProducts[whatProduct] = price;
            allPrices.Add(price);
            allProduct.Add(whatProduct);
        }
        else
        {
            var lastRemove = allPrices.Last();
            allPrices.Remove(lastRemove);
            allPrices.Add(price);
            var last = productPrice.prices.Last();
            // productPrice.prices.RemoveAt()
            productPrice.products = allProduct;
            productPrice.prices = allPrices;

        }
        allProducts[whatProduct] = price;
        productPrice.products = allProduct;
        productPrice.prices = allPrices;
    }
}

