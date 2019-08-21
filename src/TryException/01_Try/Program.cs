using System;
using System.Runtime.CompilerServices;

namespace _01_Try
{
    class Program
    {
        static int Calc(int x) => 10 / x;
        static void TryCalc()
        {
            try
            {
                int y = Calc(0);
                Console.WriteLine(y);
            }
       
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)when(e.HelpLink!=null)
            {
                Console.WriteLine("x cannot be zero");
            }

            Console.WriteLine("last statement");
        }


        static void Main(string[] args)
        {
            TryCalc();
        }
    }
}
