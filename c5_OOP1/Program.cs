using System;

namespace c5_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Desk";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 5;

            // new way to create new object:
            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Chair", UnitPrice = 80, UnitsInStock = 22 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            productManager.Update(product2);


        }
    }
}
