using System;
using System.Collections.Generic;
using System.Linq;
class ExamShopping
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        Dictionary<string, int> products = new Dictionary<string, int>();
        List<string> notExist = new List<string>();
        while (input[0] != "exam time")
        {
            if (input[0] == "stock")
            {
                var currentProducts = input[1];
                int parse;
                var isParse = int.TryParse(input[2], out parse);

                if (products.ContainsKey(currentProducts))
                {
                    var addAmountToProducts = products[currentProducts];
                    addAmountToProducts += parse;

                    products[currentProducts] = addAmountToProducts;
                }
                else
                {
                    products[currentProducts] = parse;
                }
            }

            if (input[0] == "shopping" && input[1] == "time")
            {
                while (true)
                {
                    input = Console.ReadLine().Split();
                    if (input[0] == "exam" && input[1] == "time")
                    {
                        foreach (var item in notExist)
                        {
                            Console.WriteLine(item + " doesn't exist");
                        }
                        foreach (var item in products)
                        {
                            if (item.Value > 0)
                            {

                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                        return;
                    }
                    var currenProductsBuy = input[1];
                    var currentAmountBuy = int.Parse(input[2]);
                    if (!products.ContainsKey(currenProductsBuy))
                    {
                        //Console.WriteLine($"{currenProductsBuy} doesn't exist");
                        notExist.Add(currenProductsBuy);
                    }
                    else
                    {
                        var value = products[currenProductsBuy];
                        value -= currentAmountBuy;

                        products[currenProductsBuy] = value;
                    }
                }
            }

            input = Console.ReadLine().Split();
        }
    }
}

