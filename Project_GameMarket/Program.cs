using System;

namespace Project_GameMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationManager validationManager = new ValidationManager();

            CustomerManager customerManager = new CustomerManager(validationManager);

            Customer customer = new Customer(); // dont care attribute values

            // Create function call:
            customerManager.Create(customer);

            /* -------------------- */
            // Sale simulation (with discount)

            CampaignManager campaignManager = new CampaignManager();

            SalesManager salesManager = new SalesManager(campaignManager);

            salesManager.Purchase(customer);


        }
    }
}
