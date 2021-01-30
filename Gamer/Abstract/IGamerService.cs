using System;
using System.Collections.Generic;
using System.Text;
using Gamer.Entities;

namespace Gamer.Abstract
{
    interface IGamerService
    {
        void Add(Gamer.Entities.Gamer gamer);
        void Update(Gamer.Entities.Gamer gamer);

        void Delete(Gamer.Entities.Gamer gamer);

    }
}
