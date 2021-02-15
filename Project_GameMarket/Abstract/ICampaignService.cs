using System;
using System.Collections.Generic;
using System.Text;

namespace Project_GameMarket
{
    interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void ApplyDiscount(Campaign campaign);
    }
}
