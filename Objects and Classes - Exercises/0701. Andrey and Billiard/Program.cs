using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0701.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var ProductsPrice = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var product = Console.ReadLine()
                    .Split('-')
                    .ToList();
                ProductsPrice[product[0]] = double.Parse(product[1]);
            }
            var billByPerson = new SortedDictionary<string, Dictionary<string, double>>();
            var personOrder = Console.ReadLine();
            var totalBill = 0.0;
            while (personOrder != "end of clients")
            {
                var order = personOrder.Split('-', ',');
                var person = order[0];
                var product = order[1];
                var quantity = double.Parse(order[2]);
                if (ProductsPrice.ContainsKey(product))
                {
                    if (billByPerson.ContainsKey(person))
                    {
                        if (billByPerson[person].ContainsKey(product))
                        {
                            billByPerson[person][product] += quantity * ProductsPrice[product];
                        }
                        else
                        {
                            billByPerson[person][product] = quantity * ProductsPrice[product];
                        }
                        totalBill += billByPerson[person][product];
                    }
                    else
                    {
                        billByPerson[person] = new Dictionary<string, double>();
                        billByPerson[person][product] = quantity * ProductsPrice[product];
                        totalBill += billByPerson[person][product];
                    }
                }
                personOrder = Console.ReadLine();
            }
            var finalBill = 0.0;
            foreach (var person in billByPerson)
            {
                Console.WriteLine(person.Key);
                var personalBill = 0.0;
                foreach (var bill in person.Value)
                {
                    var finalQuantity = bill.Value / ProductsPrice[bill.Key];
                    var product = bill.Key;
                    if (double.IsNaN(finalQuantity))
                    {
                        finalQuantity = 0;
                    }
                    Console.WriteLine($"-- {product} - {finalQuantity}");
                    personalBill += bill.Value;
                    finalBill += bill.Value;
                }
                Console.WriteLine($"Bill: {personalBill:f2}");
            }
            Console.WriteLine($"Total bill: {finalBill:f2}");
        }
    }
}
