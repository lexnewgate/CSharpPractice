using System;
using System.Xml;

namespace _04_Throw
{
    class Program
    {

        static void ThrowEx()
        {
            throw new ArgumentNullException("just test");
        }

        static void XThrowEx()
        {

            try
            {
                ThrowEx();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                //throw e;
                //throw;
                throw new XmlException("invalid xml",e);
            }
        }

        static void Main(string[] args)
        {
            try
            {

                XThrowEx();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
