using System;

namespace Exercise_DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4]
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1},
            };
            Diagonal(array);
            Console.ReadLine();        
        }


        static void Diagonal(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    Console.Write(a[i, k]);
                }
                Console.WriteLine();


            }


        }
    }
}