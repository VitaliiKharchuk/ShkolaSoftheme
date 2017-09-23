using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PrinterLibrary
{
    class ColourPrinter : Printer
    {
        public new void Print(string model)
        {
            Console.WriteLine("Mark  of   printer is  {0} \nIt's method of  ColourPrinter   derived  class", model);

        }


        /*
        public void Print(string model, Colour colour)
        {

            switch (colour)
            {
                case Colour.Blue:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Print(model);
                        break;
                    }
                case Colours.Red:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Print(model);
                        break;
                    }

                case Colours.White:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Print(model);
                        break;
                    }

                case Colours.Green:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Print(model);
                        break;
                    }




            }

            Console.ResetColor();

        }

    */
    }
    
}
