using System;

namespace Exercise_DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            Diagonal(array);
            Console.ReadKey();        
        }

        static void Diagonal(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {

            }


        }
    }
}
            thing(array);
            Console.ReadKey();
        }
        static void thing(int[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write(ar[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}