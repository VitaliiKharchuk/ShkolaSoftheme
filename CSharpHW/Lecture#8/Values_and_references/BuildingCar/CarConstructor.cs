using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingCar
{
    static class CarConstructor
    {
        
        public static Car Construct(Engine   eng, Color col,  Transmission  trans)
        {

            return new Car (  eng,   col,    trans) ;

        }
        

        public  static void  Reconstruct(Car car, Engine improvedEngine)
        {
           
            car.engine = improvedEngine;
        }

    }
}
