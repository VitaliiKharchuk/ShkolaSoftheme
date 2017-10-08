using System;
using System.IO;

namespace Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            ReWriter.Extention = Extentions.none;

            Console.Write("Old  string: ");
            ReWriter.OldValue = Console.ReadLine();

            Console.Write("New  string: ");
            ReWriter.NewValue = Console.ReadLine();

            Console.Write("Directory  path: ");
            string targetDirectory = Console.ReadLine();

            if (Directory.Exists(targetDirectory))
            {
                FileManager.ProcessDirectory(targetDirectory);
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
