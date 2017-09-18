using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_and_objects
{
    class Car
    {
        
        private string _model;
        private string _color;
        private int _year;

     
       public  Car ()
        {
            _model = "Ferrari";
            _color = "Black";
            _year = DateTime.Now.Year;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public   string Color
        {
            get { return _color; }
            set { _color = value; }
        }


        public  int  Year
        {
            get { return _year; }
            set { _year = value; }
        }
        
    }
}
