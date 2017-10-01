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
        public static List<MobileConnection> listConnection = new List<MobileConnection>();

        static public int GenerateNewNumber()
        {         
            _number++;
            return _number;
        }


        public static void GetFiveMostPopularNumbers()
        {

            var list = (from connection in listConnection
                        group connection.Sender.PhoneNumber by connection.Receiver.PhoneNumber into g
                        orderby g.Count() descending
                        select new
                        {
                            number = g.Key,
                            total = g.Count()
                        }).Take(5);


            foreach (var l in list)
            {

                Console.WriteLine("Number = " + l.number + "  Total " +  l.total);




            }

           // Console.WriteLine(list);
                   
        }



        public  static   void  GetFiveMostActiveAbonent()
        {

            var list = (from connection in listConnection
                        group connection.Receiver.PhoneNumber by connection.Sender into g
                        select g.Sum());
                        
                        

            foreach  (var account in  list)
            {
                Console.WriteLine(account);
            }
            
        }

        public class CaseInsensitiveComparer : IComparer<int>
        {


            public int Compare(int x, int y)
            {
                return (x > y) ? 1 : -1;
            }

            /*
            public int Compare(MobileAccount x, MobileAccount y)    
            {

                double utility1 = 0;
                double utility2 = 0;
                foreach (var account in listConnection)
                {
                    if (account.Sender.PhoneNumber == x.PhoneNumber )
                    {
                        if  (account.Type == ConnectionType.Call)
                        {
                            utility1++;
                        }

                        else
                        {
                            utility1 += 0.5;
                        }
                    }

                    if (account.Sender.PhoneNumber == y.PhoneNumber)
                    {

                        if (account.Type == ConnectionType.Call)
                        {
                            utility2++;
                        }

                        else
                        {
                            utility2 += 0.5;
                        }
                    }


                }


                return (utility1 > utility2) ? 1 : 0;
                
            }
            */
        }



        static   public  void  AddToDatabase(MobileAccount  account)
        {
            listExistingNumbers.Add(account);
        }

        public static void ShowCallInformation(MobileAccount sender, MobileAccount receiver)
        {
            listConnection.Add(new MobileConnection { Receiver = receiver, Sender = sender, Type = ConnectionType.Call });


            if (sender.PhoneNumber != receiver.PhoneNumber)
            {
                Console.Write(String.Format("Call information:  number of receiver -  {0},  time of event -  {1} , number of  sender -  {2} ",
                     receiver.PhoneNumber, DateTime.Now, sender.PhoneNumber));

                if (receiver.IsBookContainsNumber(sender))
                {
                    Console.WriteLine("name of  sender = " +sender.Name);
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
                listConnection.Add(new MobileConnection { Receiver = receiver, Sender = sender, Type = ConnectionType.Sms });

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


    /*
    public  MyClass()
    {
   
    
    }
*/
}
