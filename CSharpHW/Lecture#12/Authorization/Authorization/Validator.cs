using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authorization
{
    class Validator : IValidator
    {

         public bool ValidateUser(IUser user)
        {

            User _user;
            
          
            _user= UserDatabase.GetUserForName(user.name);

            if  (_user!=  null)
            {

                if (CheckPassword(user.password, _user.password))
                {
                    Console.WriteLine("Authorization   success\nThe  last   entrance of  {0}  was {1}", _user.name, _user.lastEntrance);
                    return true;
                }

                else
                {
                    Console.WriteLine("User  was  exists  but   password   incorrect!");
                    return false;
                }


            }


            _user = UserDatabase.GetUserForEmail(user.email);
            if (_user != null)
            {

                if (CheckPassword(user.password, _user.password))
                {
                    Console.WriteLine("Authorization   success\nThe  last   entrance of  {0}  was {1}", _user.email, _user.lastEntrance);
                    return true;
                }
                else
                {
                    Console.WriteLine("User  was  exists  but   password   incorrect!");
                    return false;
                }

            }


            UserDatabase.AddUser((User)user);
            Console.WriteLine("New  user   was  added  to  database");
           
            return false;
        }

        bool  CheckPassword(int  numeber1, int   number2)
        {
            return numeber1 == number2;
        }
    }
}
