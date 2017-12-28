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

            double e = 8;
            e = Math.Pow(e, 3);
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            bool f = f1 > f2;
            Console.WriteLine("{0} is bigger than {1}: {2}", f1, f2, f);

            int g1 = 350;
            int g2 = 200;
            bool g = 2 * g2 > g1;
            Console.WriteLine("2 times {0} is bigger than {1} : {2}", g2, g1, g);
            
            double h = 1357988018575474;
            bool hDivisor = h % 11 == 0;
            Console.WriteLine("1357988018575474 has 11 as a divisor: " + hDivisor);

            int i1 = 10;
            int i2 = 3;
            bool i = (i1 > Math.Pow(i2, 2) && i1 < Math.Pow(i2, 3));
            Console.WriteLine("{0} is higher than {1} squared and smaller than {1} cubed: {2}", i1, i2, i);

            int j1 = 1521;
            bool j;
            if (j1 % 3 == 0 || j1 % 5 == 0)
            {
                j = true;
            }
            else j = false;
            Console.WriteLine("{0} is dividable 3 or 5: {1}", j1, j);

            string k = "Apple";
            for (int l = 0; l < 4; l++)
            {
                Console.Write(k);
            }
            Console.ReadLine();
        }
    }
}
