using System;

namespace Dispose
{
    class DisposeObject:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}
