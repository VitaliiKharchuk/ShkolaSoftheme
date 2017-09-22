using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Run();

        }



        static  void  Run()
        {
            InfiniteArray array = new InfiniteArray();

            array.Add(1);
            array.Add(2);
            array.Add(5);
            array.Add(6);
            array.Add(187);
            array.Add(18);
            array.Add(10);
            array.Add(195);
            array.Add(16);
            array.Add(17);
            array.Add(18);
            array.Add(10);
            array.Add(112);



            Console.WriteLine(array.Contains(3));
            Console.WriteLine(array.Contains(2)); 

            try
            {
                Console.WriteLine(array.GetByIndex(4));
                Console.WriteLine(array.GetByIndex(0));
                Console.WriteLine(array.GetByIndex(13));
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            

            Console.ReadKey();
        }



    }

   
    
}
