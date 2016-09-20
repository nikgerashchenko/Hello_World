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
                
                var assemblyVersion = typeof(Example).Assembly;
                var attr = assemblyVersion.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
                Console.WriteLine(assemblyVersion);
                Console.WriteLine(attr.InformationalVersion);
                Console.Read();


            }

        }
    }
}
