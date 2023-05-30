using GameProject;
using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManeger());
            gamerManager.Add(new Gamer 
            { 
                Id=1,
                BirthYear=1894,
                FirstName="Sena",
                LastName="Yiğit",
                IdentityNumber=12345
            });
        }
    }
 

}