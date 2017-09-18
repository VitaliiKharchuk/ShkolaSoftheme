using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {


            var p1 = new Point();
            var p2 = new Point(1,2 );
            var p3 = new Point(1, 4);



            ShapeDescriptor des1 = new ShapeDescriptor(p1);
            ShapeDescriptor des2 = new ShapeDescriptor(p1,p1,p2,p3);
            ShapeDescriptor des3 = new ShapeDescriptor(p1,p3,p3);


    
            Console.WriteLine(des1.GetFiguareType());
            Console.WriteLine(des2.GetFiguareType());
            Console.WriteLine(des3.GetFiguareType());


            Console.ReadKey();



        }
    }
}
