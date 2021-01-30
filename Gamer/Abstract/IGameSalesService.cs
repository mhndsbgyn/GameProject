using Gamer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Abstract
{
    interface IGameSalesService
    {
    
        void SaleGame(Game game);
        void SaleUser(Gamer.Entities.Gamer gamer);
    }
}
