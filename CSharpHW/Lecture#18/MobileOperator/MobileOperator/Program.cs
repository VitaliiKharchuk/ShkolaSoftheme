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

            account1.MakeSms(account3);
            account1.MakeCall(account1);

            account2.MakeSms(account2);
            account2.MakeCall(account4);

            account2.MakeSms(account1);
            account3.MakeCall(account1);

            account4.MakeSms(account1);

            Console.ReadKey();
        }
    }
}
