using System;
using System.IO;

namespace Archiver
{
    class Program
    {
        static void Main(string[] args)
        {                    
            Console.Write("Directory  path: ");
            string targetDirectory = Console.ReadLine();

            if (Directory.Exists(targetDirectory))
            {
                FileManager.ProcessDirectory(targetDirectory, ArchiverMode.Compression);
                Console.WriteLine("Replacment  done");
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", targetDirectory);
            }

            Console.ReadKey();
        }
    }
}
