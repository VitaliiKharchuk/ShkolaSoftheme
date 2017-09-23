using System;
using MyLibrary;

namespace ExtentionApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer printer = new Printer();

            ColourPrinter colourPrinter = new ColourPrinter();

            PhotoPrinter photoPrinter = new PhotoPrinter();


            printer.Print("My  printer");
            colourPrinter.Print("A1", Colour.Green);

            photoPrinter.Print("A1", Images.Sumssung);

            
            Printer[] prArr = new  Printer[10];
            prArr.HandleArrayPrinter();
            
            ColourPrinter [] cprArr = new ColourPrinter[2];
            cprArr.HandleArrayColourPrinter();

            PhotoPrinter[] phprArr = new PhotoPrinter[7];
            phprArr.HandleArrayPhotoPrinter();

        
            Console.ReadKey();
        }
    }



}
