using System;
using System.Collections.Generic;
using System.Text;
using Gamer.Entities;

namespace Gamer.Abstract
{
    interface ICampaignService
    {
        void Add(Gamer.Entities.Campaign campaign);
        void Update(Gamer.Entities.Campaign campaign);

        void Delete(Gamer.Entities.Campaign campaign);

    }
}
