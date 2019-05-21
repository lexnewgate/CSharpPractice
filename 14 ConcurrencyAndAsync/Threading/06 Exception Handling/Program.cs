using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
*
* Any try/catch/finally blocks when a thread is created are of 
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

            var catchExInThread = new Thread(() =>
              {
                  try
                  {
                      Go();
                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine($"{Thread.CurrentThread.Name} exception");
                  }
              });
            catchExInThread.Name = nameof(catchExInThread);
            catchExInThread.Start();




            try
            {
                var catchExInOutThread = new Thread(Go);
                catchExInOutThread.Name = nameof(catchExInOutThread);

                catchExInOutThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} exception");
            }
        }



        static void Go()
        {
            throw null;
        }
    }
}
