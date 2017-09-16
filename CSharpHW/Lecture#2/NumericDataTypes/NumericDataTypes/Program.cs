using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumericDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static    void   Run()
        {


            Console.WriteLine("Description  of   signed   data  dypes");


            Console.WriteLine("sbyte");
            Console.WriteLine("default: " + default(SByte));
            Console.WriteLine("MinValue: " + SByte.MinValue);
            Console.WriteLine("MAxValue: " + SByte.MaxValue);


            Console.WriteLine("short");
            Console.WriteLine("default: " + default(Int16));
            Console.WriteLine("MinValue: " + Int16.MinValue);
            Console.WriteLine("MAxValue: " + Int16.MaxValue);


            Console.WriteLine("int");
            Console.WriteLine("default: " + default(Int32));
            Console.WriteLine("MinValue: " + Int32.MinValue);
            Console.WriteLine("MAxValue: " + Int32.MaxValue);

            Console.WriteLine("long");
            Console.WriteLine("default: " + default(Int64));
            Console.WriteLine("MinValue: " + Int64.MinValue);
            Console.WriteLine("MAxValue: " + Int64.MaxValue);

            Console.WriteLine();

            Console.WriteLine("Description  of   unsigned   data  dypes");

            Console.WriteLine("byte");
            Console.WriteLine("default: " + default(Byte));
            Console.WriteLine("MinValue: " + Byte.MinValue);
            Console.WriteLine("MAxValue: " + Byte.MaxValue);


            Console.WriteLine("ushort");
            Console.WriteLine("default: " + default(UInt16));
            Console.WriteLine("MinValue: " + UInt16.MinValue);
            Console.WriteLine("MAxValue: " + UInt16.MaxValue);


            Console.WriteLine("uint");
            Console.WriteLine("default: " + default(UInt32));
            Console.WriteLine("MinValue: " + UInt32.MinValue);
            Console.WriteLine("MAxValue: " + UInt32.MaxValue);

            Console.WriteLine("ulong");
            Console.WriteLine("default: " + default(UInt64));
            Console.WriteLine("MinValue: " + UInt64.MinValue);
            Console.WriteLine("MAxValue: " + UInt64.MaxValue);




            Console.WriteLine();
            Console.WriteLine("Description  of   floating-point   data  dypes");

            Console.WriteLine("float");
            Console.WriteLine("default: " + default(Single));
            Console.WriteLine("MinValue: " + Single.MinValue);
            Console.WriteLine("MAxValue: " + Single.MaxValue);



            Console.WriteLine("double");
            Console.WriteLine("default: " + default(Double));
            Console.WriteLine("MinValue: " + Double.MinValue);
            Console.WriteLine("MAxValue: " + Double.MaxValue);


            Console.WriteLine("decimal");
            Console.WriteLine("default: " + default(Decimal));
            Console.WriteLine("MinValue: " + Decimal.MinValue);
            Console.WriteLine("MAxValue: " + Decimal.MaxValue);






            Console.ReadKey();


        }


    }


}
