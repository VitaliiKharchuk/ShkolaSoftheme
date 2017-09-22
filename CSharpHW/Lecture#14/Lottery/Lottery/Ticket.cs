using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    class Ticket
    {
        private readonly Random random;
        private  readonly int Size = 6;
        public int[] _happyDigits;


        public Ticket()
        {

            random = new Random();
            _happyDigits = new int[Size];
            GenerateHappyTicket();

        }

        public int   this[ int index]
        {
            get
            {
                return _happyDigits[index];
            }

            set
            {
                _happyDigits[index] = value;
            }

        }


        public bool  CheckNumber(int  []  possibleWinner)
        {

            for (int  i = 0;  i < _happyDigits.Length; i++)
            {
                if (this[i] == possibleWinner[i])
                    continue;

                return false;
            }

            return  true;
        }


        public void WriteHappyTicket()
        {
           
            for  (int  i = 0; i < Size; i++)
            {
                Console.Write(_happyDigits[i]);
            }
            Console.WriteLine();
        }

        private void GenerateHappyTicket()
        {


            for (int i = 0; i < Size; i++)
            {
                _happyDigits[i] = random.Next(1, 10);
            }
        }

       

    }
}
