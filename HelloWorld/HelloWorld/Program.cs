using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
       

        class Example
        {
            static void Main()
            {
                Console.WriteLine("The version of the currently executing assembly is: {0}",
                typeof(Example).Assembly.GetName().Version);

                var assemblyVersion = typeof(Example).Assembly;
                Console.WriteLine(assemblyVersion);
                Console.Read();


            }

        }
    }
}
