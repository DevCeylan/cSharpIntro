using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GameMarket
{
    interface ICustomerService
    {
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
