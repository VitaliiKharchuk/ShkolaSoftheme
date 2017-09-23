using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {




        static void Main(string[] args)
        {


            Printer printer = new Printer();

            printer.Print("Sumsung");

            ColourPrinter model1 = new ColourPrinter();

            model1.Print("A1", Colours.Blue);

            //PhotoPrinter p = new PhotoPrinter();

            


            Console.ReadKey();

        }
    }
}
