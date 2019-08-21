using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/**
 *  Code that’s protected in such a manner—from indeterminacy in a
 *  multithreaded context—is called thread-safe
 * 
 *  special case: i++ not thread-safe
 *
 *  drawbacks:
 *  1) easy to forget
 *  2) deadlock
 */

namespace _04_Locking_and_Thread_Safety
{
    internal class Program
    {
        private static bool _done;
        private static readonly object Lock=new object();

        private static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
        }

        private static void Go()
        {
            lock (Lock)
            {
                if (_done) return;
                Console.WriteLine("done");
                _done = true;
            }
        }
    }
}
