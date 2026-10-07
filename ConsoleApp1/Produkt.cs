using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Produkt
    {
        public string name;
        public double price;
        public string category;
        public int count;
        public double wartoscmagazynu
        {
            get { return price * count; }
        }
    }
}
