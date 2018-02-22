using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestAssignment;
using System;

namespace UnitTestAssignmentTest
{
    [TestClass]
    public class ProductRepositoryTest
    {

        [TestMethod]
        public void NumberOfProducts1()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            int number = productRepo.NumberOfProducts();
            Assert.AreEqual(10,number);
        }
        [TestMethod]
        public void NumberOfProducts2()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            productRepo.AddProduct(new Product("New Product", 0, 0, "New Product"));
            int number = productRepo.NumberOfProducts();
            Assert.AreEqual(11,number);
        }
        [TestMethod]
        public void NumberOfProducts3()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            productRepo.DeleteByName("Broccoli");
            productRepo.DeleteByName("Zucchini");
            int number = productRepo.NumberOfProducts();
            Assert.AreEqual(8,number);
        }

        [TestMethod]
        public void AddProduct1()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            var addedList=productRepo.AddProduct(new Product("New Product", 0, 0, "New Product"));
            int number = addedList.Count;
            Assert.AreEqual(11,number);
        }

        [TestMethod]
        public void AddProduct2()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            var addedList = productRepo.AddProduct(new Product("New Product", 0, 0, "New Product"));
            int index = addedList.FindIndex(x=>x.Name=="New Product");
            bool value = index == addedList.Count-1;
            Assert.IsTrue(value);
        }


        [TestMethod]
        public void FindByType1()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            var cruciList = productRepo.FindByType("Cruciferous");
            int length = cruciList.Count;
            Assert.AreEqual(3,length);
        }

        [TestMethod]
        public void FindByType2()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            var marrowList = productRepo.FindByType("Marrow");
            bool value=false;
            foreach (var item in marrowList)
            {
                if (item.Type=="Marrow")
                {
                    value = true;
                }
                else
                {
                    value = false;
                    break;
                }

            }
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void DeleteByName1()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            var deletedList = productRepo.DeleteByName("Pumpkin");
            Assert.AreEqual(9, deletedList.Count);
        }
        [TestMethod]
        public void DeleteByName2()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            var deletedList = productRepo.DeleteByName("Cabbage");
            bool value = false;
            foreach (var item in deletedList)
            {
                if(item.Name=="Cabbage")
                {
                    value = true;
                    break;
                }
            }
            Assert.IsFalse(value);
        }

        [TestMethod]
        public void Buy()
        {
            var list = new List<Product> {
            (new Product("Lettuce", 10.5, 50, "Leafy green")),
            (new Product("Cabbage", 20, 100, "Cruciferous")),
            (new Product("Pumpkin", 30, 30, "Marrow")),
            (new Product("Cauliflower", 10, 25, "Cruciferous")),
            (new Product("Zucchini", 20.5, 50, "Marrow")),
            (new Product("Yam", 30, 50, "Root")),
            (new Product("Spinach", 10, 100, "Leafy green")),
            (new Product("Broccoli", 20.2, 75, "Cruciferous")),
            (new Product("Garlic", 30, 20, "Leafy green")),
            (new Product("Silverbeet", 10, 50, "Marrow"))};
            var productRepo = new ProductRepository(list);
            double total = 0;
            total = total + productRepo.Buy("Lettuce", 2);
            total = total + productRepo.Buy("Cabbage", 1);
            total = total + productRepo.Buy("Yam", 1);
            total = total + productRepo.Buy("Pumpkin", 1);
            double x =2*10.5+ 20 + 30 + 30;
            Assert.AreEqual(total, x);
        }
        [TestMethod]
        public void DeliciousSalad()
        {
            Console.WriteLine("No Matter What You Say The Salad Is Definitely Delicious ;) ");
        }
    }
}
