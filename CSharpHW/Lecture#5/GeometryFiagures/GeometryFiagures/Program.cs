using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryFiagures
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();

        }




        public  static   void   Run()
        {
            
            while (true)
            {


                label1:
                Console.WriteLine("Make a   choice");
                Console.WriteLine("Triangle -  1");
                Console.WriteLine("Square -  2");
                Console.WriteLine("Romb -  3");
                Console.WriteLine("Exit -  4");


                
                int _choice = default(Int32);

                if (!Int32.TryParse(Console.ReadLine(), out _choice))
                {
                    Console.WriteLine("Incorrect   choice  value!");
                    goto label1;
                }

               else  if  (_choice > 4)
                {
                    Console.WriteLine("Incorrect   choice  value!");
                    goto label1;
                }

                

                if (_choice == 4)   //  Exit  from  cycle
                {      
                        break;  
                }



                label2:
                Console.Write("Figuare's  size = ");
                
                int size = default(Int32);

                if ( !Int32.TryParse(Console.ReadLine(),out size))
                {
                    Console.WriteLine("Incorrect   size  value!");
                    goto label2;
                }


                if (_choice == 1)
                {
                    DrawTriangle(size);
                }
                else if (_choice == 2)
                {
                    DrawSquare(size);
                }
                else if (_choice == 3)
                {
                    DrawRomb(size);
                }

                else
                {
                    goto label1;
                }

                
            }
        }


        static  void  DrawTriangle(int size)
        {

            for (int  i = 0; i <   size; i++ )
            {
                
                for  (int  j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }


                Console.WriteLine();
            }

        }

        static void DrawSquare(int size)
        {

            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }


                Console.WriteLine();
            }

        }


        static void DrawRomb(int size)
        {

            for (int i = 0; i < size; i++)
            {

                for  (int j = 0; j <= 2*size; j++)
                {


                    if (size - i <= j && j <= size + i)
                        Console.Write("* ");

                    else Console.Write("  ");

                }

                
                Console.WriteLine();
            }

          


            for (int i = size ; i >= 0 ; i--)
            {

                for (int j = 0; j <=  2*size; j++)
                {


                    if (size - i <= j && j <= size + i)
                        Console.Write("* ");

                    else Console.Write("  ");

                }


                Console.WriteLine();
            }





        }


    }
}
