using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
*
* Any try/catch/finally blocks in effect when a thread is created are of 
* no relevance to the thread when it starts executing. 
* 
* This behavior makes sense when you consider that each thread has an 
* independent execution path.
*/


namespace _06_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                try
                {
                    Go();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("exception");
                }
            }).Start();
            //try
            //{
            //    new Thread(Go).Start();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("exception");
            //}
        }



        static void Go()
        {
            throw null;
        }
    }
}
