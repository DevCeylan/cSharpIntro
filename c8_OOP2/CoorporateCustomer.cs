using System;
using System.Collections.Generic;
using System.Text;

namespace c8_OOP2
{
    class CoorporateCustomer: Customer //inheritance
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
