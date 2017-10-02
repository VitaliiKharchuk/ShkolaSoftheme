using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperator
{
    static class MobileOperator
    {
        static public int _number = 0;
        static List<MobileAccount> listExistingNumbers = new List<MobileAccount>();
        public static List<MobileConnection> listConnection = new List<MobileConnection>();
        static readonly int quantity = 5;


        static public int GenerateNewNumber()
        {
            _number++;
            return _number;
        }
        
        public static List<Buffer> GetFiveMostPopularNumbers()
        {

            var list = (from connection in listConnection
                        where connection.Type.Equals( ConnectionType.Call)
                        group connection.Sender by connection.Receiver into g
                        orderby g.Count() descending
                        select new  Buffer
                        {
                            Account = g.Key,
                            Points = g.Count()
                        }).Take(quantity).ToList();

            return list;
        }

        public static List<Buffer> GetFiveMostActiveAbonents()
        {

            var list = listConnection.GroupBy(abonent => abonent.Sender).Select(number => new  Buffer
            {
                Account = number.Key,
                Points = number.Count(connection => connection.Type == ConnectionType.Call) +
                            number.Count(connection => connection.Type == ConnectionType.Sms) / 2
            }).OrderByDescending(rank => rank.Points).Take(quantity).ToList();

            
            return  list ;
        }

        static public void AddToDatabase(MobileAccount account)
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
}
