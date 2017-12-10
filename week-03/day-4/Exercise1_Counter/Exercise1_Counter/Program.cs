using System;

namespace Exercise1_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter(15);
            Console.ReadLine();
        }

        public static int Counter(int n)
        {
            Console.WriteLine(n);
            if (n == 0)
            {
                return 1;
            }
            return Counter(--n);
        }
    }
}
