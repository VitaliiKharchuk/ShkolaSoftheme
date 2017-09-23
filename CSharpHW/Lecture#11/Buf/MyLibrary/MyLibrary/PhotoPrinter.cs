using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class PhotoPrinter : Printer
    {
        public new void Print(string model)
        {
            Console.WriteLine("Model  of   printer is  {0} \nIt's method of   PhotoPrinter  derived  class", model);

        }


        public    void  Print (string  model, Images img)
        {
            Print(model);

            switch(img)
            {
                case Images.Canon:
                    {
                        Console.WriteLine("Photo of {0} printer", Images.Canon);
                        break;
                    }

                case Images.Sumssung:
                    {

                        Console.WriteLine("Photo  of  {0} printer", Images.Sumssung);
                        break;
                    }
            }

        }

    }
}
