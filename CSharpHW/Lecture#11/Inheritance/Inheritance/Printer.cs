using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;


namespace Inheritance
{
    class Printer
    {
        public virtual void Print(string mark)
        {
            Console.WriteLine("Mark  of  printer is {0}", mark);
        }
    }
}
