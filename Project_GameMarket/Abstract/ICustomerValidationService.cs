using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GameMarket
{
    interface ICustomerValidationService
    {
        bool CheckValidation(Customer customer);
    }
}
