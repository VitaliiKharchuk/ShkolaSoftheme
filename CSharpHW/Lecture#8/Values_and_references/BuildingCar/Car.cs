using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingCar
{
    class Car
    {

        public Color color { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }


        public Car(Engine  engine, Color color , Transmission  transmission)
        {
            this.color = color;
            this.engine = engine;
            this.transmission = transmission;

            
        }



        public void GetInfo()
        {
            Console.WriteLine(String.Format("Color = {0}  engine = {1} transmission = {2}", color, engine, transmission));
        }





    }
}
