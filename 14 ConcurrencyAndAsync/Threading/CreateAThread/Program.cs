using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CreateAThread
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "MainThread";
            //thread start is a action with com visible attr. what is com? what is attribute?
            var t = new Thread(WriteY);


            Console.WriteLine($"thread alive:{t.IsAlive}");
            t.Start();
            t.Name = "writey"; //thread can have name

            Console.WriteLine($"thread alive:{t.IsAlive}");

            for (var i = 0; i < 10; i++)
            {
                ThreadPrint("x");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }

        private static void WriteY()
        {
            for (var i = 0; i < 10; i++)
            {
                ThreadPrint("y");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }

        private static void ThreadPrint(string extra)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} print:{extra}");
        }

    }

}
