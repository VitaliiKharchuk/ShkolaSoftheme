using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace GCollector
{
    class ResourceHolderBase : IDisposable
    {

        bool _disposed = false;
        


        public virtual void Dispose()
        {
          
            Console.WriteLine("Cleaning    object  of   base   class");

            Dispose(true);
            GC.SuppressFinalize(this);

        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose managed resources in base.");
                }

                Console.WriteLine("Dispose unmanaged resources in base.");

                _disposed = true;
            }
        }


        ~ResourceHolderBase()
        {
            Dispose(false);
            Console.WriteLine("Destrouctor of   base   class");
        }


    }
}
