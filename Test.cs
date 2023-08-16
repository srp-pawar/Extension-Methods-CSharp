using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Test
    {
        static void Main(string[] args)
        {
            NewProgram newProgram=new NewProgram();
            newProgram.test3();
            newProgram.test2();
            newProgram.test1();

            int i = 4;
            Console.WriteLine("Factorial of " + i + " " + i.factorial());


        }
    }
}
