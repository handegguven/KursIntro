using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa" ;
            product1.UnitePrice = 500;
            product1.UnitesInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, 
                UnitesInStock = 5, ProductName = "Kalem", UnitePrice = 35,};

            //PascalCase   //camelCase
            //case sensitive = küçük harf büyük harf hassaslığı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1); 







        }
    }
}
