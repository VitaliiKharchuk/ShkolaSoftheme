using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authorization
{
     static class Reader
    {

        public static User ReadData()
        {
            Console.WriteLine("Authorization process");

            string _name;
            ReadName(out _name);

            string _email;
            ReadEmail(out _email);

            int _number;
            ReadNumber(out _number);
 
            return new User { name = _name, email = _email, password = _number, lastEntrance = default(DateTime) };

        }


        static  void   ReadName(out string   name)
        {
            Console.Write("Name = ");
            name = Console.ReadLine();

            if (name.Equals("exit"))
            {
                Environment.Exit(0);
            }


            Console.WriteLine();
        }

        static  void    ReadEmail(out  string  email)
        {
            Console.Write("Email = ");

            email = Console.ReadLine();

            if (email.Equals("exit"))
            {
                Environment.Exit(0);
            }


            Console.WriteLine();

        }

        static void ReadNumber(out int  number)
        {

            
            Console.Write("Number = ");
            string strNumber = Console.ReadLine();

            if  (strNumber.Equals("exit"))
            {
                Environment.Exit(0);
            }

            if (!Int32.TryParse(strNumber, out number))
            {

                Console.WriteLine();
                Console.WriteLine("Incorrect   format");
                ReadNumber(out  number);
            } 
        }

    }
}
