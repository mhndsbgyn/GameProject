using Gamer.Abstract;
using Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Concrete
{
    class CampaignManager : ICampaignService
    {

        public void Add(Campaign campaign)
        {
            Console.WriteLine("eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("güncellendi");
        }
    }
}
