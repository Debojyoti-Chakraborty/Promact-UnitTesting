using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAssignment
{
    public class ProductRepository
    {
       List<Product> productList = new List<Product>();
        public ProductRepository(List<Product> list)
        {
            this.productList = list;
        }
        public int NumberOfProducts()
        {
            return this.productList.Count;
        }
        public List<Product> AddProduct(Product newProduct)
        {
            this.productList.Add(newProduct);
            return this.productList;
        }
        public List<Product> FindByType(string type)
        {
            List<Product> typedList = new List<Product>();
            typedList = this.productList.Where(x => x.Type == type).ToList();
            return typedList;
        }
        public List<Product> DeleteByName(string name)
        {
            this.productList.RemoveAll(x => x.Name == name);
            return this.productList;
        }
        public double Buy(string name, int quantity)
        {
            var item = this.productList.FirstOrDefault(x => x.Name == name);
            return item.Price * quantity;
        }
    }
}
