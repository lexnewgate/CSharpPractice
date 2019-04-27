using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JoinAndSleep
{
    static class Program
    {
        static void Main(string[] args)
        {
            Thread t= new Thread(WriteY);

            Thread watcht= new Thread(()=>
            {
                IsTAlive(t);
            });

            t.Start();
            watcht.Start();

            Console.WriteLine(t.ThreadState.Simplify());

        }

        static void IsTAlive(Thread t)
        {
            while (t.IsAlive)
            {
                Console.WriteLine(t.ThreadState.Simplify());
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }

            Console.WriteLine("t is dead");
        }


        static void WriteY()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.Write("y");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }

        }

        public static ThreadState Simplify(this ThreadState ts)
        {
            return ts&(ThreadState.Unstarted|ThreadState.WaitSleepJoin|ThreadState.Stopped);
        }
    }
}
