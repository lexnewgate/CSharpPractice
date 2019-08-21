using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_UsingStatement
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void HandleFile()
        {
            using (StreamReader reader=File.OpenText("file.txt"))
            {
                
            }
        }

        void HandleFile1()
        {
            {
                StreamReader reader = File.OpenText("file.txt");
                try
                {

                }
                finally
                {
                    reader?.Dispose();
                }

            }
        }
    }
}
