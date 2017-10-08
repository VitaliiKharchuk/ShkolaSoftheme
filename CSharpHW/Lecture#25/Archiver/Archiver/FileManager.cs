using System;
using System.IO;
using System.Threading;

namespace Archiver
{
    class FileManager
    {
        private static string[] fileEntries;
        delegate void GetTypeCompession(Object o);

        public static void ProcessDirectory(string targetDirectory, ArchiverMode mode)
        {
            GetTypeCompession typeCompression;
            if (mode == ArchiverMode.Compression)
            {
                typeCompression = RegularCompression;
            }
            else
            {
                typeCompression = RegularDeCompression;
            }

            fileEntries = Directory.GetFiles(targetDirectory);

            int len = fileEntries.Length;
            Counter counter = new Counter();

            counter.Start = 0;
            counter.Finish = len / 4;
            Thread thread1 = new Thread(new ParameterizedThreadStart(typeCompression));
            thread1.Start(counter);
            thread1.Join();

            counter.Start = len / 4 + 1;
            counter.Finish = len / 2;
            Thread thread2 = new Thread(new ParameterizedThreadStart(typeCompression));
            thread2.Start(counter);
            thread2.Join();

            counter.Start = len / 2 + 1;
            counter.Finish = 3 * len / 4;
            Thread thread3 = new Thread(new ParameterizedThreadStart(typeCompression));
            thread3.Start(counter);
            thread3.Join();

            counter.Start = 3 * len / 4 + 1;
            counter.Finish = len - 1;
            Thread thread4 = new Thread(new ParameterizedThreadStart(typeCompression));
            thread4.Start(counter);
            thread4.Join();

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory, mode);
        }

        public static void RegularCompression(Object obj)
        {
            Counter c = (Counter)obj;

            for (int i = c.Start; i <= c.Finish; i++)
            {
                if (i < fileEntries.Length)
                    CompressFile(fileEntries[i]);
            }
        }

        public static void RegularDeCompression(Object obj)
        {
            Counter c = (Counter)obj;

            for (int i = c.Start; i <= c.Finish; i++)
            {
                if (i < fileEntries.Length)
                    DeCompressFile(fileEntries[i]);
            }
        }

        public static void CompressFile(string path)
        {
            if (!Path.GetExtension(path).Equals(".zip"))
                Compressor.Compress(path, path + ".zip");
        }

        public static void DeCompressFile(string path)
        {
            if (Path.GetExtension(path).Equals(".zip"))
                Compressor.Decompress(path, path.Substring(0, path.Length - 3));
        }
    }
}
