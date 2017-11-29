using System;

namespace Exercise_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
                {
                sum += s[i];
                }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

