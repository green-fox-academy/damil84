using System;

namespace Exercise_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = { 3, 4, 5, 6, 7 };
            for (int i = 0; i < aj.Length / 2; i++)
            {
                int tmp = aj[i];
                aj[i] = aj[aj.Length - i - 1];
                aj[aj.Length - i - 1] = tmp;
            }
            Console.WriteLine("Reverse order: {0}", string.Join(", ", aj));
            Console.ReadLine();
        }
    }
}
