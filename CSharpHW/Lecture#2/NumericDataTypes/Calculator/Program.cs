using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();

        }

        static void  Run()
        {

            while (true)
            {
                Double op1 = ReadDouble();
                Double op2 = ReadDouble();
                

                Console.WriteLine("Choose  operation  or    exit");

                Console.WriteLine("Add  +");
                Console.WriteLine("Sub  -");
                Console.WriteLine("Mult  *");
                Console.WriteLine("Div  /");
                Console.WriteLine("Rem  %");


                Console.WriteLine("For  exit  write  'end'");


                String instruction = Console.ReadLine();


                if (instruction.CompareTo("end") == 0)
                {
                    return;
                }


                switch (instruction)
                {
                    case "+":
                        {
                            Console.WriteLine( op1 + " + "  + op2 + " = " +   Add(op1, op2));
                            break;
                        }

                    case "-":
                        {
                            Console.WriteLine(op1 + " - " + op2 + " = " + Sub(op1, op2));
                            break;
                        }

                    case "*":
                        {
                            Console.WriteLine(op1 + " * " + op2 + " = " + Mult(op1, op2));
                            break;
                        }

                    case "/":
                        {
                            Console.WriteLine(op1 + " / " + op2 + " = " + Div(op1, op2));
                            break;
                        }

                }
            }

            
        }




        public  static  double Add(double  op1,  double op2)
        {
            return op1 + op2;
        }

        public static double Sub(double op1, double op2)
        {
            return op1 - op2;
        }
        public static double Mult(double op1, double op2)
        {
            return op1 * op2;
        }
        public static double Div(double op1, double op2)
        {
            return op1 / op2;
        }
        



        public static   double  ReadDouble()
        {

            Console.Write("Enter  operand of  double  type: ");
            String doubleValue =  Console.ReadLine();

            double operand;

            if (Double.TryParse(doubleValue, out operand))
            {
                // double here
                Console.WriteLine(operand);
                return operand;
            }


            Console.WriteLine("Incorrect  value.  Try   again!");
            ReadDouble();


            return default(Double); 
        }



    }
}
