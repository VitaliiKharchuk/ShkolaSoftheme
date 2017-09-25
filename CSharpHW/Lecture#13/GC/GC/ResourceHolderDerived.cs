using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCollector
{
    class ResourceHolderDerived : ResourceHolderBase, IDisposable   
    {

        bool _disposed = false;
        ~ResourceHolderDerived()
        {
            Console.WriteLine("Destrouctor of   derived  class");
        }


        public new  void    Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("Cleaning    object  of   derived   class");
        }

        protected override void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose managed resources in derive.");
                }

                Console.WriteLine("Dispose unmanaged resources in derive.");

                _disposed = true;
            }
        }

    }
}
