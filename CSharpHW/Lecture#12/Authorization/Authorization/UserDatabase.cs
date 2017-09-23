using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authorization
{
    static class UserDatabase
    {

        static  private List<User> database =  new List<User>();

        static private DateTime lastVisiterDate =  default(DateTime);
          
        static  public void  AddUser(User   user)
        {
            user.lastEntrance = DateTime.Now;
            database.Add(user);
        }


        static  public User  GetUserForName(string _name)
        {
            foreach(var   user in   database)
            {
                if (  _name.ToLower().Equals(user.name.ToLower()) )
                {

                    lastVisiterDate = user.lastEntrance;
                    return  user;
                }
            }
            return null; 
        }


        static  public  User GetUserForEmail(string _email)
        {
            foreach (var user in database)
            {
                if (_email.ToLower().Equals(user.email.ToLower()))
                {
                    lastVisiterDate = user.lastEntrance;
                    return   user;
                }
            }
            return  null;
        }


        static   public int GetSizeDatabase()
        {
            return database.Count;
        }

        static  public DateTime GetUserLastEntrance()
        {
            return lastVisiterDate;
        }

    }
}
