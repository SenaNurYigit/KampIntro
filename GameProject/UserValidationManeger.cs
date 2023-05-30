using GamerProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManeger : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName== "Sena" && gamer.LastName== "Yiğit" && gamer.IdentityNumber== 12345 )
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
