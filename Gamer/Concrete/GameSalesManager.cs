using Gamer.Abstract;
using Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Concrete
{
    class GameSalesManager : IGameSalesService
    {
        ICampaignService _compaignService;


        public GameSalesManager(ICampaignService campaignService)
        {
            _compaignService = campaignService;
        }

      
        public void SaleGame(Game game)
        {
            if(game.GameName== "PUBG")
            {
                Console.WriteLine("PUBG SEÇİLDİ.");
            }
        }

        public void SaleUser(Entities.Gamer gamer)
        {
            if(gamer.GamerName== "Gizem")
            {

                Console.WriteLine("Oyun Gizem'e satıldı");
            }
            else
                Console.WriteLine("hata");
        }
    }
}
