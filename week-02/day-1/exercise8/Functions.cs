using System;
using System.Collections.Generic;
using System.Text;

namespace exercise8
{
    class Functions
    {
        public void Calculations()
        {
            int a = 123;
            int b = 526;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swapping a= " + a);
            Console.WriteLine("after swapping b= " + b);
        }
    }
}
