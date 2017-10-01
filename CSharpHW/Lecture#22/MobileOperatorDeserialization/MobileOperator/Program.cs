using System;
using System.Collections.Generic;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {


            
            List<MobileAccount> list1 = new List<MobileAccount>
            {
                new MobileAccount { Name = "Jordan", PhoneNumber = 0, Contacts = new List<int> { 1,2} },
                new MobileAccount { Name = "Bolt", PhoneNumber = 1, Contacts = new List<int> { 1, 4 } },
                new MobileAccount { Name = "Messi", PhoneNumber = 2, Contacts = new List<int> { 5, 7, 5, 67, 787 } },
                new MobileAccount { Name = "Ronaldo", PhoneNumber = 3 },
                new MobileAccount { Name = "Phelps", PhoneNumber = 10 }
             };
        
            
            MyXmlSerializer.Serialize(list1, "account.xml");
            MyCompressor.Compress("account.xml", "account.zip");
            MyCompressor.Decompress("account.zip",  "account2.xml");            
            List<MobileAccount>  list2 = MyXmlSerializer.DeSerialize("account2.xml");


            foreach (var  account  in list2 )
            {
                Console.WriteLine(account.Name + " " + account.PhoneNumber);
            }

            Console.ReadKey();
        }
    }
}
