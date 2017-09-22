using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] number = Seller.GuessTicket();

            Ticket happyTicket = new Ticket();

            Console.WriteLine(happyTicket.CheckNumber(number));
            happyTicket.WriteHappyTicket();


            Console.ReadKey();
            
        }
    }
}
