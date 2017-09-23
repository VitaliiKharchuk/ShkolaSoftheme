using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {


            Validator validator = new Validator();

            while (true)
            {

                var _user = Reader.ReadData();

                validator.ValidateUser(_user);



                  

            }


 
            Console.ReadKey();

        }
    }
}
