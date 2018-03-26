using System;

namespace _6th_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DiagonalMatrix();
            Console.ReadLine();
        }

        public static void DiagonalMatrix()
        {
            Console.Write("Please give me the numer of your choosing --> ");
            int number = int.Parse(Console.ReadLine());
            int[,] array = new int[number, number];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        Console.Write("1");
                    }
                    else
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
