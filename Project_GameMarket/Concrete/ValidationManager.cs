using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GameMarket
{
    class ValidationManager : ICustomerValidationService
    {
        public bool CheckValidation(Customer customer)
        {
            // rules and conditions..
            // ..
            Console.WriteLine("user id approved");
            // Simulating accepted registration
            return true;
        }
    }
}
