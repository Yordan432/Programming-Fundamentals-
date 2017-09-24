using System;
using System.Collections.Generic;
using System.Linq;
class HandsofCards
{
    static void Main()
    {
        Dictionary<string, List<string>> Dictionary = new Dictionary<string, List<string>>();

        var input = Console.ReadLine().Split(' ').ToList();
        List<string> names = new List<string>();
        List<string> cards = new List<string>();
        var indx = 0;
        while (input[0] != "JOKER")
        {
            var element = input[indx].Split(new char[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var item in element)
            {
                names.Add(item);
            }
            for (int i = 0; i < input.Count - 1; i++)
            {
                var cardElement = input[i + 1].Split(new char[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in cardElement)
                {
                    cards.Add(item);
                }
            }

            if (!Dictionary.ContainsKey(names[0]))
            {
                Dictionary[names[0]] = new List<string>();
            }
            if (!Dictionary.ContainsValue(element))
            {
                Dictionary[names[0]].AddRange(cards);
            }
            

            input = Console.ReadLine().Split(' ').ToList();
            names.Clear();
            cards.Clear();
        }
        Dictionary = Dictionary.ToDictionary(c => c.Key, c => c.Value.Distinct().ToList());
        List<int> totalSum = new List<int>();
        foreach (var item in Dictionary)
        {
            Console.WriteLine($"{item.Key} ---> {string.Join(" " , item.Value)}");


            var currentValueFromItem = item.Value.Count;
            for (int i = 0; i < currentValueFromItem; i++)
            {
                var cardElement = item.Value[i].Split(new char[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string currentElement = cardElement[0];

                char[] currentItemElement = currentElement.ToCharArray();
                int tempSum = 0;
                int j = 11;
                int q = 12;
                int k = 13;
                int a = 14;
                if (currentItemElement[1] == 'S')
                {
                    int s = 4;
                    tempSum += (currentItemElement[0] * s);
                    totalSum.Add(tempSum);
                }
                else if(currentElement[1] == 'H')
                {
                    var value = currentElement[0];
                    value -= '0';
                    int h = 3;
                    tempSum += (value * h);
                    totalSum.Add(tempSum);
                }
                else if(currentElement[1] == 'D')
                {

                }
                else if (currentElement[1] == 'C')
                {
                    var value = currentElement[0];
                    value -= '0';
                    int c = 1;
                    tempSum +=(value * c);
                    totalSum.Add(tempSum);
                }
                else if (currentElement[1] == 'J')
                {

                }
                else if(currentElement[1] == 'Q')
                {

                }
                else if (currentElement[1] == 'K')
                {

                }
                else if (currentElement[1] == 'A')
                {
                    var value = currentElement[0];
                    
                    //  A - 14
                    // 14 x 4 = 56
                }               
            }
        }
    }
}

