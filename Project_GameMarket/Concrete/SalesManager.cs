using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GameMarket
{
    class SalesManager : ISalesService
    {
        CampaignManager campaignManager;

        public SalesManager(CampaignManager campaignManager)
        {
            this.campaignManager = campaignManager;
        }

        public void Purchase(Customer customer)
        {
            // operate business rules.
            campaignManager.ApplyDiscount(new Campaign() { DiscountRate = 0.9 });
            Console.WriteLine("The product is purchased. Thank you");
        }
    }
}
