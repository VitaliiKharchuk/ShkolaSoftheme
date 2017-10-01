using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            MobileAccount account1 = new MobileAccount("Bolt");
            MobileAccount account2 = new MobileAccount("Messi");
            MobileAccount account3 = new MobileAccount("Ronaldo");
            MobileAccount account4 = new MobileAccount("Phelps");


            account1.AddToContacts(account2);
            account1.AddToContacts(account3);

            account2.AddToContacts(account1);
            account2.AddToContacts(account3);


            account1.MakeCall(account2);
            account1.MakeCall(account2);
            account1.MakeCall (account3);

            
            account2.MakeCall(account1);
            account2.MakeCall(account3);

            account3.MakeCall(account4);
            


            //MobileOperator.GetFiveMostPopularNumbers();
            MobileOperator.GetFiveMostActiveAbonent();


            Console.ReadKey();
        }
    }
}
