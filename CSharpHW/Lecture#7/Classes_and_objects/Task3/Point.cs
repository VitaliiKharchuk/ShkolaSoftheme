using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Point
    {

        private double x;
        private double y;
        

        public Point()
        {
            x = y = 0;
        }

        public Point(int x)
        {

            this.x = x;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


    }
}
