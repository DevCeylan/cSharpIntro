using System;
using System.Collections.Generic;
using System.Text;

namespace c5_OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int MyProperty { get; set; }
        public int UnitsInStock { get; set; }

    }
}

// Attributes of a Product type-class
// CRUD operations must be separated.