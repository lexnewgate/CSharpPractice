using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Finally
{
    class Program
    {
        static int Calc(int x) => 10 / x;
        static void TryCalc()
        {
            try
            {
                //return;
                int y = Calc(0);
                Console.WriteLine(y);
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                //return;
                Console.WriteLine("x cannot be zero");
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.WriteLine("last statement");
        }


        static void Main(string[] args)
        {
            TryCalc();
        }
    }
}
