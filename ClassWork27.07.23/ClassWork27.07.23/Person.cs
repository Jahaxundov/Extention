using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork27._07._23
{
    internal static class Person
    {

        public static string Name { get; set; }

        public static void Test()
        {
            Console.WriteLine("Test");
        }

        static Person()
        {
            Console.WriteLine("Static");
        }
    }
}
