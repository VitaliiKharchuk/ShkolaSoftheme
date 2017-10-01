using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace MobileOperator
{
    class MobileAccount : IComparable
    {

        public delegate void AccountHandler(MobileAccount  accountSender, MobileAccount  accountReceiver);
        public event AccountHandler CallEvent;
        public event AccountHandler SmsEvent;
        private List<MobileAccount> Contacts = new List<MobileAccount>();
        

        public string Name { get; }
        public int PhoneNumber { get; }

        public MobileAccount (String  name)
        {
            Name = name;
            PhoneNumber = MobileOperator.GenerateNewNumber();
            MobileOperator.AddToDatabase(this);
            CallEvent += MobileOperator.ShowCallInformation;
            SmsEvent += MobileOperator.ShowSmsInformation;
        }

        
        public bool  IsBookContainsNumber(MobileAccount  sender)
        {
            foreach (var  contact in Contacts )
            {
                if (contact.PhoneNumber.Equals(sender.PhoneNumber))
                {
                    return true;
                }
            }
            return false;
        }


        public   void   AddToContacts(MobileAccount inputNumber)
        {
            Contacts.Add(inputNumber);
        }
        
        public void MakeCall(MobileAccount receiver)
        {
            if (CallEvent != null)
            {     
                CallEvent(this, receiver);        
            }
        }
  
        public void MakeSms(MobileAccount receiver)
        {
            if (SmsEvent != null)
            {
                 SmsEvent(this, receiver);              
            }
        }

        public int CompareTo(object obj)
        {
            //throw new NotImplementedException();
            return 1; 
        }
    }
}
