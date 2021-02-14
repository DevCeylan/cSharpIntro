using System;

namespace c8_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Mehmet";
            customer1.Surname = "Ceylan";
            customer1.TcNo = "3333333333";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "98765";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "123456789";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
