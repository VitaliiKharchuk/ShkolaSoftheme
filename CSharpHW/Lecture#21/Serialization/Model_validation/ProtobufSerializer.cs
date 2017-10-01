using System.Collections.Generic;
using ProtoBuf;
using System.Diagnostics;
using System;
using System.IO;

namespace Serialization
{
    static class ProtobufSerializer
    {
        static readonly int iterationCount = 1000;

        public static void TestProtoBuf(List<Book> books)
        {
            var stopwatch = new Stopwatch();

            using (FileStream fs = new FileStream("book.txt", FileMode.OpenOrCreate))
            {
                stopwatch.Restart();

                for (var i = 0; i < iterationCount; i++)
                {
                    fs.Position = 0;
                    Serializer.Serialize(fs, books);
                }

                stopwatch.Stop();

                Console.WriteLine("Protobuf  serialization: {0} iterations in {1} ms", iterationCount, stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
