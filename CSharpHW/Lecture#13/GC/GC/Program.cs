using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC
{
    class Program
    {
        static void Main(string[] args)
        {
          
            using ( var baseHolder = new ResourceHolderBase())
            {

            }

                      
           var derivedHolder1 = new ResourceHolderDerived();
           derivedHolder1.Dispose();
           derivedHolder1.Dispose();

            var derivedHolder2 = new ResourceHolderDerived();            
        }
    }
}
