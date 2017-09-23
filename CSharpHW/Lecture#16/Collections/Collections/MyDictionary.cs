using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class MyDictionary<T,K>
    {
        private List<T> keys;
        private List<K> values;

        public   MyDictionary()
        {
            keys = new List<T>();
            values = new List<K>();
        }

        public  K this [T key]
        {
            get
            {
                int index = GetElementPosition(key);
                
                if  (index != -1)
                {
                    return values[index];
                }
                
               Console.WriteLine("Element with  that  key  doesn't  exist in    dictionary");  
               return default (K);
            }

            set
            {
                int index = GetElementPosition(key);
                if (index != -1)
                {
                    values[index] = value;
                }

                keys.Add(key);
                values.Add(value);

                
            }


        }

        public void Add(T  key, K  value)
        {
            if  (GetElementPosition(key)  != -1)
            {
                Console.WriteLine("Element  already  exists in   dictionary");
                return;
            }
            keys.Add(key);
            values.Add(value);

        }


        


        private  int   GetElementPosition(T  key)
        {
            int len = this.keys.Count;
            
            for (int  i = 0; i < len; i++)
            {
                if (keys[i].Equals( key))
                {
                    return i;
                }
            }


            return -1;
        }

    }
}
