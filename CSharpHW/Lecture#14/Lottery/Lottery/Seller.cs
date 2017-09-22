using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    static class Seller
    {

        const  int Size = 6; 

        public static int  []  GuessTicket()
        {

            int [] digits = new int[Size];


            for   (int  i = 0; i < Size; i++)
            {


                bool res = false;
                do
                {
                    Console.Write(String.Format("Digit {0} = ",  i + 1));
                    res = Int32.TryParse(Console.ReadLine(), out digits[i]);
                    if (!res ||  digits[i] < 1 || digits[i] > 9)
                    {
                        Console.WriteLine("Incorrect  format!");
                    }


                } while(!res);
                



            }

            return digits;
        }

    }
}
