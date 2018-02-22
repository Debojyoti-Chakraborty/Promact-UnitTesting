using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();
            list.Add(new Product("Lettuce", 10.5, 50, "Leafy green"));
            list.Add(new Product("Cabbage", 20, 100, "Cruciferous"));
            list.Add(new Product("Pumpkin", 30, 30, "Marrow"));
            list.Add(new Product("Cauliflower", 10, 25, "Cruciferous"));
            list.Add(new Product("Zucchini", 20.5, 50, "Marrow"));
            list.Add(new Product("Yam", 30, 50, "Root"));
            list.Add(new Product("Spinach", 10, 100, "Leafy green"));
            list.Add(new Product("Broccoli", 20.2, 75, "Cruciferous"));
            list.Add(new Product("Garlic", 30, 20, "Leafy green"));
            list.Add(new Product("Silverbeet", 10, 50, "Marrow"));
            var productRepo = new ProductRepository(list);
        }
    }
}
