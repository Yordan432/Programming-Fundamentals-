using System;
using System.Collections.Generic;
using System.Linq;

class ArrayHistogram
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        input.Sort();

        Dictionary<string, int> counter = new Dictionary<string, int>();

        int count = 1;
        int indx = 0;
        for (int i = 0; i < input.Count - 1; i++)
        {
            while (input[i] == input[indx + 1])
            {
                count++;
                indx++;
                i++;
                if (indx == input.Count - 1)
                {
                    counter.Add(input[indx], count);
                    return;
                }

            }
            counter.Add(input[indx], count);
            indx++;
            count = 1;
            if (indx == input.Count - 1)
            {
                counter.Add(input[indx], count);

                break;
            }
        }
        var sort = counter.OrderBy(x => x.Value);
        var reverse = sort.Reverse();

        List<double> profit = new List<double>();
        foreach (var item in reverse)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
        double resul = 0.0;
        foreach (double items in counter.Values)
        {
            resul = (items / input.Count);
            var x = resul * 100;
            profit.Add(x);
        }
        foreach (var item in profit)
        {
            Console.WriteLine("{0:F2}" , item);
        }
        var counters = counter.Values.Count;
        Console.WriteLine(counters);
    }
}

