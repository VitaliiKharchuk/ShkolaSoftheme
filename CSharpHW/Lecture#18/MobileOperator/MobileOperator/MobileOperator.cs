using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileOperator
{
    static class MobileOperator
    {

        static public int _number = 0;
        static List<MobileAccount> listExistingNumbers = new List<MobileAccount>();

        
        static public int GenerateNewNumber()
        {         
            _number++;
            return _number;
        }


        static   public  void  AddToDatabase(MobileAccount  account)
        {
            listExistingNumbers.Add(account);
        }

        public static void ShowCallInformation(MobileAccount sender, MobileAccount receiver)
        {
            if (sender.PhoneNumber != receiver.PhoneNumber)
            {
                Console.Write(String.Format("Call information:  number of receiver -  {0},  time of event -  {1} , number of  sender -  {2} ",
                     receiver.PhoneNumber, DateTime.Now, sender.PhoneNumber));

                if (receiver.IsBookContainsNumber(sender))
                {
                    Console.WriteLine("name of  sender = " + sender.Name);
                }

                else
                {
                    Console.WriteLine("unknown  number");
                }

            }

            else
            {
                WarningCall();
            }

            Console.WriteLine();
        }

        public static void ShowSmsInformation(MobileAccount sender, MobileAccount receiver)
        {
            if (sender.PhoneNumber != receiver.PhoneNumber)
            {
                Console.Write(String.Format("Sms information:  number of receiver -  {0},  time of event -  {1} , number of  sender -  {2} ",
                     receiver.PhoneNumber, DateTime.Now, sender.PhoneNumber));

                if (receiver.IsBookContainsNumber(sender))
                {
                    Console.WriteLine("name of  sender = " + sender.Name);
                }

                else
                {
                    Console.WriteLine("unknown  number");
                }
            }

            else
            {
                WarningSms();
            }

            Console.WriteLine();
        }

        public static void WarningCall()
        {
            Console.WriteLine("Impossible  to  call   on  your own number");
        }

        public static void WarningSms()
        {
            Console.WriteLine("Impossible  to  sent  SMS on  your own number");
        }
    }
}
