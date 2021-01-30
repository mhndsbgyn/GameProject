using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Entities
{
  public  class Gamer
    {
        public int GamerId { get; set; }
        public string GamerName { get; set; }

        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }
    }
}
