
using System;
using System.Collections.Generic;

namespace MobileOperator
{
    [Serializable]
    public class MobileAccount
    {

        public List<int> Contacts = new List<int>();
        
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

 
        public   void   AddToContacts(MobileAccount inputNumber)
        {
            Contacts.Add(inputNumber.PhoneNumber);
        }

   
    }
}
