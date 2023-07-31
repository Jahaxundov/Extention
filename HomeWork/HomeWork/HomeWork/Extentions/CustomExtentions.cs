using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Extentions
{
    internal static class CustomExtentions
    {
        public static int Factorial(this int num)
        {
            int result = 1;
            for (int i = 1; i <=num ; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
