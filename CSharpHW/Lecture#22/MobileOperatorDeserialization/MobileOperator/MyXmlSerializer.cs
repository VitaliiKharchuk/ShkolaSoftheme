using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace MobileOperator
{

    class MyXmlSerializer
    {
        public static void Serialize(List<MobileAccount> books, string  fileTarget)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<MobileAccount>));
            
            using (FileStream fs = new FileStream(fileTarget, FileMode.OpenOrCreate))
            {
                fs.Position = 0;
                formatter.Serialize(fs, books);
            }


            Console.WriteLine("Serialization  was  compleated");
        }


        public  static  List<MobileAccount>  DeSerialize(string fileSource)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<MobileAccount>));
            StreamReader reader = new StreamReader(fileSource);
            var accounts = (List<MobileAccount>)serial.Deserialize(reader);
            reader.Close();


            Console.WriteLine("Deserialization  was  compleated");

            return accounts;    
        }
    }
}
