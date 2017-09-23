using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class Printer
    {

        public virtual void Print(string mark)
        {
            Console.WriteLine("Mark  of  printer is {0}", mark);
        }
    }
}
