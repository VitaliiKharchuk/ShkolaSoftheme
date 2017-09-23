using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC
{
    class ResourceHolderDerived : ResourceHolderBase, IDisposable   
    {


        ~ResourceHolderDerived()
        {
            Console.WriteLine("Destrouctor of   derived  class");
        }


        public new  void    Dispose()
        {
            //base.Dispose();
            Console.WriteLine("Cleaning    object  of   derived   class");
        }



    }
}
