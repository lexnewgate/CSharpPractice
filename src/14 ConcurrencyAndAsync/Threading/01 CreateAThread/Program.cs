using System;
using System.Threading;


namespace CreateAThread
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "MainThread";
            //thread start is a action with com visible attr. what is com? what is attribute?

            var job = new Thread(WriteY);
            job.Name = "writey"; //thread can have name
            job.Start();

            Console.WriteLine($"thread alive:{job.IsAlive}");

            for (var i = 0; i < 10; i++)
            {
                ThreadPrint($"x {i}");
                if (job.IsAlive)
                {
                    Console.WriteLine($"{job.Name} is still alive");
                }
                Thread.Sleep(TimeSpan.FromSeconds(1));

            }
        }

        private static void WriteY()
        {
            for (var i = 0; i < 10; i++)
            {
                ThreadPrint($"y {i}");
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }
        }

        private static void ThreadPrint(string extra)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} print:{extra}");
        }

    }

}
