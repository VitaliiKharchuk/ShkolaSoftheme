using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Diagnostics;

namespace Serialization
{
    class MyJsonSerializer
    {

        public   static void Serialize(List<Book> books)
        {

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Book>));
            var stopwatch = new Stopwatch();
            stopwatch.Restart();

            for (int i = 0; i < 1000; i++)
            {
                using (FileStream fs = new FileStream("book.json", FileMode.OpenOrCreate))
                {

                    fs.Position = 0;
                    jsonFormatter.WriteObject(fs, books);
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Json  serialization was  comleted {0} ms", stopwatch.ElapsedMilliseconds);            
        }
    }
}
