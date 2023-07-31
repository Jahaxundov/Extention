using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork27._07._23
{
    internal struct  Animal
    {
        public void GetAge(int? age = null)
        {
            if (age == null)
            {
                Console.WriteLine("No found");
                return;
            }
            Console.WriteLine(age);
        }
    }
}
