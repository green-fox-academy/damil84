using System;

namespace exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            e = e * e * e;
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            bool f = true;
            f = (f1 > f2);
            Console.WriteLine(f);

            int g1 = 350;
            int g2 = 200;
            bool g = true;
            g = (2 * g2 > g1);
            Console.WriteLine(g);
            
            //int h = 1357988018575474;
            //bool hhh = true;
            //hhh = (h / 11);
            // tell if it has 11 as a divisor (print as a boolean)

            int i1 = 10;
            int i2 = 3;
            bool i = true;
            i = (i1 > i2 * i2 && i1 < i2 * i2 * i2);
            Console.WriteLine(i);

            int j = 1521;
            bool j1 = true;
            j1 = (j / 3 || j / 5);

            // tell if j is dividable by 3 or 5 (print as a boolean)

            string k = "Apple";
            k = k + k + k + k;
            Console.WriteLine(k);

            Console.ReadLine();
            
        }
    }
}
