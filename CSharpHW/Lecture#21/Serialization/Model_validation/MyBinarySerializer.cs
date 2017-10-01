using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace Serialization
{
    static class MyBinarySerializer
    {
        static readonly int iterationCount = 1000;

        public static void Serialize(List<Book> books)
        {
            
            BinaryFormatter formatter = new BinaryFormatter();

            var stopwatch = new Stopwatch();
            stopwatch.Restart();

            for (int i = 0; i < iterationCount; i++)
            {

                using (FileStream fs = new FileStream("book.dat", FileMode.OpenOrCreate))
                {

                    fs.Position = 0;
                    formatter.Serialize(fs, books);
                    //fs.Position = 0;
                    //var restoredTasks = (List<Book>)formatter.Deserialize(fs);
                }

            }

            stopwatch.Stop();
            Console.WriteLine("Binary  serialization was  comleted {0} ms", stopwatch.ElapsedMilliseconds);            
        }
    }
}
