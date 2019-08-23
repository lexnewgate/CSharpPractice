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



    class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass derived= (DerivedClass)new BaseClass();

            DerivedClass derived= new BaseClass() as DerivedClass;
        }
    }
}
