using System;
using System.IO;
using System.Threading.Tasks;

namespace Replacer
{
    class FileManager
    {
        delegate void GetTypeCompession(Object o);

        public static void ProcessDirectory(string targetDirectory)
        {
            var fileEntries = Directory.GetFiles(targetDirectory);
 
            Parallel.ForEach(fileEntries, ReWriter.ReWrite);        
            
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }
    }
}
