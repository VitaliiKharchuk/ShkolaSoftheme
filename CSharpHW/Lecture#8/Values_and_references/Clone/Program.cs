using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clone
{
    class Program
    {

        static void Main(string[] args)
        {
            Run();
        }


        static void  Run()
        {
            User user1 = new User { firstName = "Bob", lastName =  "Arum", ID =  100 , OS =  new OperationSystem { nameSystem = "Windows" } };
            User user2 = (User)user1.Clone();

            user2.lastName = "Dav";
            user2.OS.nameSystem = "IOS";
           
            user1.GetUserInformation();
            user2.GetUserInformation();

            Console.WriteLine("Deep  cloning  was   done");
           
            
            Console.ReadKey();




        }



    }
}
