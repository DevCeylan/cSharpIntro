using System;
using System.Collections.Generic;
using System.Text;

namespace c3_Methods
{
    class CartManager
    {

        public void Add(Product product)
        {
            Console.WriteLine("Product added to cart: " + product.Name);
        }

        public void Add2(string productName, string description, double price)
        {
            Console.WriteLine("Product added to cart: " + productName);
        }


    }
}
