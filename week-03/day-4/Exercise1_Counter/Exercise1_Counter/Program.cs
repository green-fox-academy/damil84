using System;

namespace Exercise1_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter(15000);
            Console.ReadLine();
        }

        public static int Counter(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(n);
                return Counter(n - 1);
            }
        }
    }

}
