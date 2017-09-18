using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Model = " + car.Model);
            Console.WriteLine("Color = " + car.Color);
            Console.WriteLine("Year = " +  car.Year);
            Console.WriteLine();

            TuningAtelier.TuneCar(car);
            
            Console.WriteLine("After  painting:");

            Console.WriteLine("Model = " + car.Model);
            Console.WriteLine("Color = " + car.Color);
            Console.WriteLine("Year = " + car.Year);



            Console.ReadKey();
        }


    }




}
