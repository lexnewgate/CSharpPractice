using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Base
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("baseClass Ctor");
        }
    }

    public class DerivedClass:BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("derived Ctor");
        }
    }

    struct MyStruct
    {
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            //System.ValueType
            new DerivedClass();
        }
    }
}
