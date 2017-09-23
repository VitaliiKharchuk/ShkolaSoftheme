using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrinterLibrary
{
    class PhotoPrinter : Printer
    {

        public new void Print(string model)
        {
            Console.WriteLine("Mark  of   printer is  {0} \nIt's method of   PhotoPrinter  derived  class", model);

        }

    }
}
