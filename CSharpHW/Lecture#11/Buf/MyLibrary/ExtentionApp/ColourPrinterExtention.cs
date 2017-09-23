using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace ExtentionApp
{

    public static class ColourPrinterExtention
    {
        public static void HandleArrayColourPrinter(this ColourPrinter[] arr)
        {
            Console.WriteLine("This is   my   method  for    processing   of   ColourPrinter []  array ");
        }
    }


}
