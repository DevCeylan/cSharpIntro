// DRY: Dont Repeat Yourself.
using System;

namespace c3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Laptop";
            product.Price = 2100;
            product.Id = 0000023;
            product.Description = "Acer Aspire v772g";

            CartManager cartManager = new CartManager();
            cartManager.Add(product);
        }
    }
}
