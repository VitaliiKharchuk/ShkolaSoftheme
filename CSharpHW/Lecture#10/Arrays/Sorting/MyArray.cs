using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class MyArray
    {
        private readonly Random _random = new Random();
        
        private  readonly int _size;

        private readonly int _range = 10000;

        private int[] _numbers;


        public MyArray(int size)
        {
            _size = size;
            _numbers = new int [_size];
            GenerateArray();
        }


        private  void  GenerateArray()
        {

            for  (int  i = 0; i < _size; i++)
            {
                _numbers[i] = _random.Next(0, _range);
            }

        }


        public  int []  getArray()
        {
            return _numbers;
        }

        public void WriteArray()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.Write(_numbers[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
