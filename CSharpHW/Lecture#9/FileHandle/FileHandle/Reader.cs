using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace FileHandle
{
    static class Reader
    {
        
        public static FileHandle OpenForRead(string _filePath)
        {

            return  new FileHandle(GetFileName(_filePath),
                _filePath,
                GetFileSize(_filePath),
                 FileAccessEnum.Read
                );

        }


        public static FileHandle OpenForWrite(string _filePath)
        {


            return new FileHandle(GetFileName(_filePath),
                _filePath,
                GetFileSize(_filePath),
                 FileAccessEnum.Write
                );


        }



        public static long GetFileSize(string _fileName)
        {
            FileInfo file = new FileInfo(_fileName);

            return file.Length;
        }

        public static string GetFileName(string _fileName)
        {
            
            string[] parts =  _fileName.Split(new Char[] { '\\' });

            int len = parts.Length;

            return parts[len - 1];          
        }



        public static  FileHandle OpenFile(string _fileName, FileAccessEnum _status)
        {
            
            return _status == FileAccessEnum.Read ?   OpenForRead(_fileName ) :  OpenForWrite(_fileName);

        }


        public static   void  ReadWrite(string _fileName)
        {
            Console.WriteLine("Open file " + _fileName );
            Process.Start(_fileName);
        }

    }
}
