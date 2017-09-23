using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class ColourPrinter :  Printer
    {
        public   new void  Print(string  model)
        {
            Console.WriteLine("Mark  of   printer is  {0} \nIt's method of  ColourPrinter   derived  class",  model);

        }



        public   void   Print  (string model,  Colours colour)
        {

            switch(colour)
            {
                case Colours.Blue:
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

    }
}
