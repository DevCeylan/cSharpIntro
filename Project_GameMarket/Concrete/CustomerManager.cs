using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GameMarket
{
    class CustomerManager : ICustomerService
    {
        ICustomerValidationService customerValidationService;

        // constructor
        public CustomerManager(ICustomerValidationService customerValidationService)
        {
            this.customerValidationService = customerValidationService;
        }

        // methods
        public void Create(Customer customer)
        {
            //..
            // Simulating accepted registration
            if(customerValidationService.CheckValidation(customer))
            Console.WriteLine("New account Created!");
            else
            Console.WriteLine("registration failed!");
        }

        public void Delete(Customer customer)
        {
            //..
            Console.WriteLine("Account updated!");
        }

        public void Update(Customer customer)
        {
            //..
            Console.WriteLine("Account deleted");
        }
    }
}
