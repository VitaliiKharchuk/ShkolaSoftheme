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
            MobileAccount account5 = new MobileAccount("Arum");
            MobileAccount account6 = new MobileAccount("Canelo");
            MobileAccount account7 = new MobileAccount("Pique");


            account1.AddToContacts(account2);
            account1.AddToContacts(account3);

            account2.AddToContacts(account1);
            account2.AddToContacts(account3);

            account3.AddToContacts(account1);
            account3.AddToContacts(account2);
            account3.AddToContacts(account3);
            account3.AddToContacts(account4);

            account4.AddToContacts(account1);
            account4.AddToContacts(account3);
            account4.AddToContacts(account4);


            account1.MakeCall(account2);
            account1.MakeSms(account2);
            account1.MakeSms(account2);
            account1.MakeCall (account3);
            
            account2.MakeSms(account1);
            account2.MakeSms(account3);
            account2.MakeSms(account3);
            account2.MakeCall(account4);


            account3.MakeSms(account1);
            account3.MakeSms(account1);
            account3.MakeSms(account1);
            account3.MakeSms(account1);
            account3.MakeSms(account1);
            account3.MakeSms(account1);
            account3.MakeSms(account1);

            account4.MakeCall(account1);
            account4.MakeCall(account2);
            account4.MakeCall(account3);
            account4.MakeCall(account1);
            account4.MakeCall(account2);
            account4.MakeSms(account2);

            account5.MakeCall(account6);
            account5.MakeCall(account4);

            account6.MakeCall(account3);
            account6.MakeSms(account3);

            account7.MakeCall(account5);


            List<Buffer> list1 =  MobileOperator.GetFiveMostPopularNumbers();
            List<Buffer> list2  =   MobileOperator.GetFiveMostActiveAbonents();
            
            Console.WriteLine("The most pupular   numbers");
            foreach (var account in list1)
            {
                Console.WriteLine("Number of {0} :'+{1}'  has   rank : {2}",account.Account.Name, account.Account.PhoneNumber, account.Points);
            }
            
            Console.WriteLine("The  most  active abonents");
            foreach (var  account in  list2)
            {
                Console.WriteLine("Number of {0}: '+{1}'  was called : {2} times ",account.Account.Name, account.Account.PhoneNumber, account.Points);
            }
            
            Console.ReadKey();
        }
    }
}
