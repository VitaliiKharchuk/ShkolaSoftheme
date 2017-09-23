using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;

namespace ExtentionApp
{
   
    public static class PhotoPrinterExtention
    {
        public static void HandleArrayPhotoPrinter(this PhotoPrinter[] arr)
        {
            Console.WriteLine("This is   my   method  for    processing   of   PhotoPrinter []  array");
        }
    } 
}
