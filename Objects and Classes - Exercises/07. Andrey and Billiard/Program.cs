using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split('-');
                var product = input[0];
                var price = double.Parse(input[1]);
                if (!productsPrice.ContainsKey(product))
                {
                    productsPrice[product] = 0;
                }
                productsPrice[product] = price;
            }
            var tokens = Console.ReadLine();
            var shopList = new Dictionary<string, double>();
            List<Customer> clients = new List<Customer>();
            while (tokens != "end of clients")
            {
                var token = tokens.Split('-', ',');
                var name = token[0];
                var prod = token[1];
                var quantity = double.Parse(token[2]);
                shopList = new Dictionary<string, double>();
                if (!productsPrice.ContainsKey(prod))
                {
                    tokens = Console.ReadLine();
                    continue;
                    
                }
                if (clients.Any(a => a.Name == name))
                {
                    Customer customer = clients.First(a => a.Name == name);
                    if (!customer.ShopList.ContainsKey(prod))
                    {
                        customer.ShopList.Add(prod, quantity);
                    }
                    else
                    {
                        customer.ShopList[prod] += quantity;
                    }
                    customer.Bill += quantity * productsPrice[prod];
                }
                else 
                {
                    Customer customer = new Customer();
                    customer.Name = name;
                    customer.ShopList = new Dictionary<string, double>();
                    customer.ShopList.Add(prod, quantity);
                    customer.Bill += (quantity * productsPrice[prod]);
                    clients.Add(customer);
                }
                
                tokens = Console.ReadLine();
            }
            double totalBills = 0.0;
            foreach (Customer item in clients.OrderBy(a => a.Name))
            {
                Console.WriteLine(item.Name);
                foreach (var it in item.ShopList)
                {
                    Console.WriteLine($"-- {it.Key} - {it.Value}");
                }
                Console.WriteLine($"Bill: {item.Bill:f2}");
                totalBills = totalBills + item.Bill;
            }
            Console.WriteLine($"Total bill: {totalBills:f2}");
        }
    }
}
