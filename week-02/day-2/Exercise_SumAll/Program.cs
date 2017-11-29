using System;

namespace Exercise_SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = new int[] { 3, 4, 5, 6, 7 };
            int sum = 0;
            for (int i = 0; i < ai.Length; i++)
            {
                sum += ai[i];
            }
            Console.WriteLine(sum);
            Console.Readline();
        }
    }
}