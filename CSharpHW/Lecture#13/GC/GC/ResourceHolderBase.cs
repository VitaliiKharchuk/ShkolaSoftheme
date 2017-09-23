using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace GC
{
    class ResourceHolderBase : IDisposable
    {

         ~ResourceHolderBase()
         {
            Console.WriteLine("Destrouctor of   base   class");
         }


        public virtual void Dispose()
        {
          
            Console.WriteLine("Cleaning    object  of   base   class");
        }





    }
}
