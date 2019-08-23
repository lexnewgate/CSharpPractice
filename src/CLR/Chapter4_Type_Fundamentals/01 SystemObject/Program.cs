using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SystemObject
{
    class Program
    {
        class Test
        {
            private int b;

            void a()
            {
                Console.WriteLine(b);
            }


        }

        public static int b;

        struct MyStruct
        {
            
        }

        static void Main(string[] args)
        {
            int a=2;
            Test test=new Test();
            MyStruct my;

            Console.WriteLine(b);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a is System.Object);
            Console.WriteLine(test is System.Object);
            Console.WriteLine(my is System.Object);
        }
    }
}
