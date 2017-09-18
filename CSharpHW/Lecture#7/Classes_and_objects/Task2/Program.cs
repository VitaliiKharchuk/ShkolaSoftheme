using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            Human h2 = new Human();
            Human h3 = new Human( default(DateTime), "Leo", "Messi", 30 );


            Console.WriteLine(h1.MyEquals(h2));
            Console.WriteLine(h1.MyEquals(h3));
            Console.WriteLine(h2.MyEquals(h3));


            Console.ReadKey();
        }
    }
}
