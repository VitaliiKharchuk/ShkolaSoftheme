using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleElement
{
    class Program
    {
        static void Main(string[] args)
        {

            MyArray arr = new MyArray();

            //arr.WriteArray();
            Console.WriteLine("Spare  element  is " + arr.GetSpare());

            Console.ReadKey();
        }
    }
}
