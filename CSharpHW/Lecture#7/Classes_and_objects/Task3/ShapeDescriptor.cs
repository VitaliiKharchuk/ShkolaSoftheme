using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class ShapeDescriptor
    {


        private string _type;

        public  ShapeDescriptor()
        {
            _type = "unknown";
        }

        public ShapeDescriptor(params Point [] points)
        {
            GetFigureType(points);
        }



        public string  GetFiguareType()
        {
            return _type;
        }

        private  void GetFigureType(params Point [] points)
        {
            int len = points.Length;

            switch (len)
            {

                case 1:
                    {
                        _type =  "point";
                        break;
                    }

                case 2:
                    {
                        _type = "segment";
                        break;
                    }
                case 3:
                    {
                        _type = "triangle";
                        break;
                    }
                case 4:
                    {
                        _type = "rectangle";
                        break;
                    }
                case 5:
                    {
                        _type = "pentagon";
                        break;
                    }
                case 6:
                    {
                        _type = "hexagon";
                        break;
                    }

                case 7:
                    {
                        _type = "heptagon";
                        break;
                    }


                default:
                    {
                        _type = "Circle";
                        return;
                    }



            }


        }



    }
}
