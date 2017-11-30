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

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write(array[i, k]);
                }
                Console.WriteLine();


            }
            Console.ReadLine();        
        }


    }
}