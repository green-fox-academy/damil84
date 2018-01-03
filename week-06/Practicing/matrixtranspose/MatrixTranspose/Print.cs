using System;

namespace MatrixTranspose
{
    public class Print
    {
        public void Printer(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    Console.Write(arr[i, k]);
                }
                Console.WriteLine();
            }
            return;
        }
    }
}
