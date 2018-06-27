using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIfDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #if DEBUG
            Console.WriteLine("DEBUG is defined");
            #endif

            Console.Read();


        }
    }
}
