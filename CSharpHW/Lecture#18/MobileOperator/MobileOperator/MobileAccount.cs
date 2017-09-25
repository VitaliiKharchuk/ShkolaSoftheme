using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace MobileOperator
{
    class MobileAccount
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
            this.CallEvent += MobileOperator.ShowCallInformation;
            this.SmsEvent += MobileOperator.ShowSmsInformation;
        }

        
        public bool  IsBookContainsNumber(MobileAccount  inputNumber)
        {
            foreach (var  contact in Contacts )
            {
                if (contact.PhoneNumber.Equals(inputNumber.PhoneNumber))
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

        public void MakeCall(MobileAccount receiverNumber)
        {
            if (CallEvent != null)
            {     
                CallEvent(this, receiverNumber);  
            }
        }

      
        public void MakeSms(MobileAccount receiverNumber)
        {
            if (SmsEvent != null)
            {
                 SmsEvent(this, receiverNumber);              
            }
        }
    }
}
