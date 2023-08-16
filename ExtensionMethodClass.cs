using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{

    internal static class ExtensionMethodClass
    {
        public static void test3(this NewProgram p)
        {
            Console.WriteLine("test 3 extension method is called");
        }

        public static int factorial(this Int32 x)
        {
            if (x < 0) return -1;
            int result = 1;
            for(int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
