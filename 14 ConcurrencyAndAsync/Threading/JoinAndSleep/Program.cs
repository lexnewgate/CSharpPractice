using System;
using System.Threading;

/**
 *  Sleep and Join make program block.
 *
 *  t.Join means wait for t to end
 *
 *  sleep(0) and thread.yield relinquish to other threads
 *  yield only relinquish to other threads on same core
 */

/*
 * Thread state can only be used for debug;
 */

/*
 *  Blocking or unblocking cause context switch. Small overhead typically 1 or 2 microsecs.
 *
 *  Two bounds: i/o bound and compute bound
 */

/*
 * block vs spin
 *
 * spin:
 * 1. periodically spin
 * 2. spin continuously
 *
 * 1 vs 2 turn i/o bound into compute bound waste cpu. But it will better in case of context switching
 * blocking itself does not incur zero cost. Async helps.
 */

namespace JoinAndSleep
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var t= new Thread(WriteY);
            t.Start();

            new Thread((() =>
            {
                while (true)
                {
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.WriteLine("press a");
                    }
                }
            })).Start();

            t.Join();


            for (var i = 0; i < 10; i++)
            {
                Console.Write("x");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }


        }

        private static void WriteY()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.Write("y");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }

        }

        public static ThreadState Simplify(this ThreadState ts)
        {
            return ts & (ThreadState.Unstarted | ThreadState.WaitSleepJoin | ThreadState.Stopped);
        }
    }
}
