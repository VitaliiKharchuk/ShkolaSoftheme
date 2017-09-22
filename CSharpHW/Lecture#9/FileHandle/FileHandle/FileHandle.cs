using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileHandle
{
    struct FileHandle
    {
        public long fileSize { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }
        public FileAccessEnum status { get; set; }


        public FileHandle (string _fileName,  string _filePath,  long _fileSize , FileAccessEnum _status)
        {
            fileName = _fileName;
            filePath = _filePath;
            fileSize = _fileSize;
            status = _status;

        }

        public  void  GetInfo()
        {
            Console.WriteLine("File = " + fileName + '\n' +  "Path = " + filePath + '\n' + "Size = " + fileSize + '\n' + "Status = " + status);
        }
        
    }
}
