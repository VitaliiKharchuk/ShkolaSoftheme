using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
     class InfiniteArray
    {

        private  int actualCapacity; 
        private readonly int increaserSizeArray;
        
        private  int [] _numbers;
        
        public InfiniteArray  ()
        {

            increaserSizeArray = 5;
            actualCapacity = 0;
            _numbers = new int[increaserSizeArray];
            
        }

        public    int GetByIndex(  int index)
        {

            if (index >= _numbers.Length)
                throw new IndexOutOfRangeException();

            return _numbers[index];
        }


        
        public  bool Contains ( int element)
        {


            for  (int  i = 0; i < actualCapacity; i++)
            {
                if (_numbers[i] == element)
                    return true;
            }

            return false;

        }


        public    void  Add(int additionalElement)
        {

            int len = _numbers.Length;

            if (actualCapacity < len)
            {
                _numbers[actualCapacity] = additionalElement;
                actualCapacity++;
            }

            else
            {

                int [] newArray = new int[len + increaserSizeArray];

                for (int i = 0; i < len; i++)
                {
                    newArray[i] = _numbers[i];
                }



                _numbers = newArray;

                
                Console.WriteLine("Copy  was  done! Length  of  array = " +  _numbers.Length);


                Add(additionalElement);

            }



        }        



    }
}
