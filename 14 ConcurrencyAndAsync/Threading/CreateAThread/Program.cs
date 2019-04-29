using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * Why use thread?
 *  1. make full use of multi core cpu
 *  2. better for single cpu
 *      1) io-bound 
 *      2) simulate concurrency
 */
namespace CreateAThread
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //thread start is a action with com visible attr. what is com? what is attribute?
            var t = new Thread(WriteY);


            Console.WriteLine($"thread alive:{t.IsAlive}");
            t.Start();
            t.Name = "writey"; //thread can have name

            Console.WriteLine($"thread alive:{t.IsAlive}");

            for (var i = 0; i < 1000; i++)
            {
                WriteThreadName("x");
            }
        }

        private static void WriteY()
        {
            for (var i = 0; i < 1000; i++)
            {
                WriteThreadName("y");
            }
        }

        static void WriteThreadName(string extra)
        {
            Console.WriteLine( $"thread name:{Thread.CurrentThread.Name}:{extra}"); 
        }

    }

}
