using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Entities.Gamer gamer);
    }
}
