using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;
namespace UnitTestProjectSales
{
    [TestClass]
    public class TestProduct
    {
        SaleLoader sales = new SaleLoader();
        [TestMethod]
        public void TestFile()
        {
            List<Product> ProductFile = sales.ReadAllFile();
            List<Product> product = new List<Product>();
            product.Add(new Product
            {
                Name = "Спрайт",
                Price = 300,
                Count = 10 
            });
            product.Add(new Product
            {
                Name = "Фанта",
                Price = 500,
                Count = 12
            });
            product.Add(new Product
            {
                Name = "Кола",
                Price = 200,
                Count = 7
            });
            CollectionAssert.AreEqual(product, ProductFile);
            //все товары у которых цена быльше чем х
        }
    }
}
