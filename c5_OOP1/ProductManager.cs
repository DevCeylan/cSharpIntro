using System;
using System.Collections.Generic;
using System.Text;

namespace c5_OOP1
{
    // in order to solve "separation of concerns" problems, CRUD methods will be defined in this class.
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated");
        }

    }
}
