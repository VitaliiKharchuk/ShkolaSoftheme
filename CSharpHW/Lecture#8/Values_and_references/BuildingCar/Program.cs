using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingCar
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = CarConstructor.Construct(Engine.diesel, Color.Black,  Transmission.manual);
            car.GetInfo();

            CarConstructor.Reconstruct(car, Engine.petrol);
            car.GetInfo();

            Console.ReadKey();

        }
    }
}
