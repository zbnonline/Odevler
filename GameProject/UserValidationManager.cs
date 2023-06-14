using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "ÖMER" && gamer.LastName == "ZABUNOĞLU" && gamer.BirthYear == 2000 && gamer.IdentityNumber == 616161 )
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
