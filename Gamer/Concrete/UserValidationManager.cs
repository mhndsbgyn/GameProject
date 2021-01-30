using Gamer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Entities.Gamer gamer)
        {
            if (gamer.IdentityNumber == 12345)
            {
                return true;

            }
            else
                return false;
        }
    }
}
