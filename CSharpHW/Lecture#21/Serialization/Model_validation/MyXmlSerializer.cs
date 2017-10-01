using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Diagnostics;

namespace Serialization
{
    class MyXmlSerializer
    {

        public static  void Serialize(List<Book> books)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
            var stopwatch = new Stopwatch();
            stopwatch.Restart();

            for (int i = 0; i < 1000; i++)
            {
                using (FileStream fs = new FileStream("book.xml", FileMode.OpenOrCreate))
                {

                    fs.Position = 0;
                    formatter.Serialize(fs, books);                   
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Xml  serialization was  comleted {0} ms", stopwatch.ElapsedMilliseconds);

        }
    }
}
