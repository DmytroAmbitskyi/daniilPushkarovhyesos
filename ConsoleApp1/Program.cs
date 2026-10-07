using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public void Main()
        {
            List<Produkt> products = new List<Produkt>
            {
                new Produkt { name = "Produkt1", price = 15.99, category = "category1", count = 5 },
                new Produkt { name = "Produkt2", price = 10.00, category = "category2", count = 3 },
                new Produkt { name = "Produkt3", price = 21.99, category = "category3", count = 2 },
                new Produkt { name = "Produkt4", price = 17.50, category = "category2", count = 2 }
            };

            Console.WriteLine("Lista produktów:");

            foreach (var p in products)
            {
                Console.WriteLine(p.name);
            }
            Console.WriteLine("Lista produktów tanszych niz 20:");
            foreach (var p in products.Where(p => p.price < 20))
            {
                Console.WriteLine(p.name);
            }
            Console.WriteLine("Produkty sortowane wedlug ceny:");
            foreach (var p in products.OrderBy(p => p.price))
            {
                Console.WriteLine(p.name);
            }
        }
    }
}