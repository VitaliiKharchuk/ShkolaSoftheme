using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace ExtentionApp
{

    public static class PrinterExtention
    {
        public static void HandleArrayPrinter(this Printer[] arr)
        {
            Console.WriteLine("This is   my   method  for    processing   of    Printer []    array");
        }
    }

}
