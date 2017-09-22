using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace FileHandle
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var doc1 = Reader.OpenForRead("Files\\Sample1.txt");
            doc1.GetInfo();

            var doc2 = Reader.OpenFile("Files\\Sample2.txt",FileAccessEnum.Write);
            doc2.GetInfo();
            
            Reader.ReadWrite("Files\\Sample3.txt");

            Console.ReadKey();
        }
    }
}
