using Gamer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.Concrete
{
    class GamerManager : IGamerService
    {
       IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Entities.Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            { Console.WriteLine("Kayıt Eklendi");
            }

            else
                Console.WriteLine("eklenmedi hata");
        }

        public void Delete(Entities.Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }



        public void Update(Entities.Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}

