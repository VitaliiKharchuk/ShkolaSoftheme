using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authorization
{
    class User : IUser
    {
        public User()
        {
            name = default(String);
            password = default(int);
            email = default(String);
            lastEntrance = DateTime.Now;
        }


        public int password { get; set; }

        public DateTime lastEntrance { get; set; }

        public string name { get; set; }
        
         public string email   { get; set; }
        

        
        public void GetFullInfo()
        {
            Console.Write("Name = {0}  Password = {1} Email = {2}", name, password, email);
            return;
        }


    }
}
