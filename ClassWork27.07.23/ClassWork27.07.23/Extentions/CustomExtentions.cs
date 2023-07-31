using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassWork27._07._23.Extentions
{
    internal static class CustomExtentions
    {
        public static int Sum(this int num,int num2)
        {
            return num +num2;
        }

        public static bool HasStr(this string str,string serach)
        {
            return str.Contains(serach);
        }

        public static bool CheckDigit(this string str,string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

        public static  void Test(this Book book)
        {
            Console.WriteLine(book.Name);
        }
    }
}
