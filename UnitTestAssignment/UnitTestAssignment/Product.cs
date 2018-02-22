using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAssignment
{
   public class Product
    {
        public string Name;
        public string Type;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int quantity,string type)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }
    }
}
