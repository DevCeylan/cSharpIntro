using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GameMarket
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            //..
        }

        public void ApplyDiscount(Campaign campaign)
        {
            Console.WriteLine("discount applied");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            //..
        }

        public void UpdateCampaign(Campaign campaign)
        {
            // ..
        }
    }
}
