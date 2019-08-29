using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CastTypes
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


    class AClass
    {
        
    }

    struct BStruct
    {
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            System.ValueType b = a;
        }
    }
}
