using System;
using System.IO;
using System.IO.Compression;

namespace Archiver
{
    class Compressor
    {
            public static void Compress(string sourceFile, string targetFile)
            {

                using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
                {
                    using (FileStream targetStream = new FileStream(targetFile, FileMode.OpenOrCreate))
                    {
                        using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                        {
                            sourceStream.CopyTo(compressionStream); // копируем байты из одного потока в другой
                            Console.WriteLine("Compression  of  file {0} was  compleated. Original  size: {1}  Compressed  size: {2}.",
                                sourceFile, sourceStream.Length.ToString(), targetStream.Length.ToString());
                        }
                    }
                }
            }

            public static void Decompress(string compressedFile, string targetFile)
            {
                using (FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate))
                {
                    using (FileStream targetStream = new FileStream(targetFile, FileMode.OpenOrCreate))
                    {
                        using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(targetStream);
                            Console.WriteLine("Recovered  file: {0}", targetFile);
                        }
                    }
                }
            }     
    }
}
