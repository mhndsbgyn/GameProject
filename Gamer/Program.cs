using Gamer.Concrete;
using System;

namespace Gamer
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Entities.Gamer
            {
                IdentityNumber = 12345
            }) ;

            GameSalesManager gameSalesManager = new GameSalesManager(new CampaignManager());
            gameSalesManager.SaleGame(new Entities.Game
                {
                GameName = "PUBG"
            });

            GameSalesManager gameSalesManager1 = new GameSalesManager(new CampaignManager());
            gameSalesManager1.SaleUser(new Entities.Gamer
              {
                GamerName="Gizem"
            }
                );

        }
    }
}
