using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 *  The CLR assigns each thread its own memory stack so that local variables are kept
 *  separate.
 *
 *  Threads share data if they have a common reference to the same object instance
 *
 *  Local variables captured by a lambda expression or anonymous delegate are converted
 *  by the compiler into fields, and so can also be shared
 *
 *  Static fields offer another way to share data between threads
 */

namespace _03_LocalVsSharedState
{
    class Program
    {
        private bool _instanceVar;

        static void Main(string[] args)
        {
            //LocalVarsTest();
            SameInstanceTest();
        }

        #region TestEntries

        static void LocalVarsTest()
        {
            Thread.CurrentThread.Name = "Main";
            new Thread(Go).Start();
            Go();
        }

        static void SameInstanceTest()
        {
            var p=new Program();
            new Thread(p.CommonRefToSameInstanceTest).Start();
            p.CommonRefToSameInstanceTest();
        }

        #endregion

        /// <summary>
        /// The output is actually indeterminate
        /// </summary>
        public void CommonRefToSameInstanceTest()
        {
            if (!_instanceVar)
            {
                Console.WriteLine("Done");
                _instanceVar = true;
            }
        }

        static void Go()
        {
            for (int cycles = 0; cycles < 5; cycles++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}:{cycles} ?");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
