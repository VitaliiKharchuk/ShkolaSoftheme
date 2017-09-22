using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleElement
{
    class MyArray
    {
        private  readonly int _size = 10001;

        private readonly Random _random = new Random();

        private int[] _numbers;


        public MyArray()
        {
            GenerateArray();
        }


        private void   GenerateArray()
        {
            _numbers = new int[_size + 1];

            int steps = (_size + 1) / 2;

            for  (int i = 0; i < steps; i++)
            {
                _numbers[i] = i;
                _numbers[i  + steps] = i;

            }


            int spareIndex = _random.Next(0, _size + 2);


            if  (spareIndex != _size + 1)
            {
                int substituteIndex = _random.Next(0, _size + 1);
                Swap( ref _numbers[spareIndex], ref _numbers[substituteIndex]);
            }


            for  (int  i = 0; i <  _size; i++)
            {
                Swap( ref _numbers[i],ref _numbers[_random.Next(0, _size + 1)]);
            }

              
        }

        
        public  int GetSpare()
        {
            int res = 0;

            for (int i = 0; i < _size; i++)
            {
                res = res ^ _numbers[i];
            }

            return res;
        }
        

        public  void  WriteArray()
        {
            for  (int  i = 0; i < _size; i++)
            {
                Console.Write(_numbers[i] + " ");
            }
            Console.WriteLine();
        }

        static public void  Swap( ref int   value1,   ref  int  value2)
        {
            int tmp = value1;
            value1 = value2;
            value2 = tmp;
        }
        
    }
}
