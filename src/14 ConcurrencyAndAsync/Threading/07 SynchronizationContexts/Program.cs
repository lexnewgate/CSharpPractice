using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_SynchronizationContexts
{
    class Program
    {
        private static SynchronizationContext _synchronizationContext;
        static void Main(string[] args)
        {
            _synchronizationContext= new SynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(_synchronizationContext);


            if (_synchronizationContext == null)
            {
                Console.WriteLine("sync is null");
            }

            new Thread((() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("new");
                    Thread.Sleep(TimeSpan.FromSeconds(1)); 
                }

                Console.WriteLine("Post");//test post and send here
                _synchronizationContext.Send((state =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(1)); 
                        Console.WriteLine("run on main thread");
                    }


                }),null);

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    Console.WriteLine("new");
                }
                
                // _synchronizationContext


            })).Start();

            for (int i = 0; i < 100; i++)
            {
               Thread.Sleep(TimeSpan.FromSeconds(1)); 
               Console.WriteLine("mainThread");
            }
        }
    }
}
